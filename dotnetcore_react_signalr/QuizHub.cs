using dotnetcore_react_signalr.Enums;
using dotnetcore_react_signalr.Helpers;
using dotnetcore_react_signalr.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace dotnetcore_react_signalr
{
    public class QuizHub : Hub
    {
        private static Dictionary<string, QuizUserModel> _users = new Dictionary<string, QuizUserModel>();

        public IEnumerable<string> RegisteredUsers => _users.Values.Select(p => p.Name);

        public IEnumerable<QuizUserModel> UsersPoints => _users.Values;

        public Dictionary<QuizCategory, List<QuestionModel>> Questions = QuestionsHelper.GetAllQuestions();

        //Send message to specified group
        //public async Task SendMessageToGroup(string groupName, string message)
        //{
        //    await Clients.Group(groupName).SendAsync("receiveMessage", message);
        //}

        ////Send message to all
        //public async Task SendMessage(string message)
        //{
        //    await Clients.All.SendAsync("receiveMessage", message);
        //}

        ////Send message to Caller
        //public async Task SendMessageToCaller(string message)
        //{
        //    await Clients.Caller.SendAsync("receiveMessage", message);
        //}

        ////Methods to add to group and remove from group 
        //public async Task AddToGroup(string groupName)
        //{
        //    await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        //    await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the group");
        //}

        public async Task<bool> RegisterSession(string username)
        {
            if (_users.Any(p => p.Value.Name.Equals(username, StringComparison.InvariantCultureIgnoreCase)))
            {
                return false;
            }

            lock (_users)
            {
                var connectionID = Context.ConnectionId;
                if (!_users.ContainsKey(connectionID))
                {
                    _users.Add(connectionID, new QuizUserModel { Name = username, Points = 0 });
                }
            }

            await RetrieveScores();
            return true;
        }

        public async Task RetrieveScores()
        {
            await Clients.All.SendAsync("updateUsersPoints", UsersPoints);
        }

        public async Task GetQuestions()
        {
            await Clients.All.SendAsync("receiveQuestion", Questions.FirstOrDefault());
        }

        public void ClearSession()
        {
            _users.Clear();
        }

        public async Task ResetPointsToZero()
        {
            lock (_users)
            {                
                foreach(var userPoints in _users.Values)
                {
                    userPoints.Points = 0;
                }
            }

            await RetrieveScores();
        }

        public async Task GetCategoryQuestions(QuizCategory quizCategory)
        {
            var categoryQuestions = Questions[quizCategory];
            foreach (var question in categoryQuestions)
            {
                await Clients.Others.SendAsync("receiveQuestion", quizCategory, question);
                await Task.Delay(10000);
                var correctAnswer = question.Answers.FirstOrDefault(p => p.AnswerId.Equals(question.CorrectAnswerId)).AnswerText;
                await Clients.Others.SendAsync("displayAnswer", correctAnswer);
                await Task.Delay(5000);
            }

            await Clients.Others.SendAsync("roundComplete", quizCategory);
        }

        public async Task SubmitAnswer(QuizCategory quizCategory, int questionId, int answerId)
        {
            var categoryQuestions = Questions[quizCategory];
            var question = categoryQuestions.FirstOrDefault(p => p.QuestionId.Equals(questionId));
                
            if (question.CorrectAnswerId.Equals(answerId))
            {
                lock (_users)
                {
                    var connectionID = Context.ConnectionId;
                    if (_users.TryGetValue(connectionID, out QuizUserModel userPoints))
                    {
                        userPoints.Points += 1;                        
                    }
                }

                await RetrieveScores();
            }
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            lock (_users)
            {
                var connectionID = Context.ConnectionId;
                if (_users.ContainsKey(connectionID))
                {
                    _users.Remove(connectionID);
                }
            }

            return base.OnDisconnectedAsync(exception);
        }

        //public override Task OnConnectedAsync()
        //{
            //var id = Context.GetHttpContext().Connection.Id;
            //string name = Context.User.Identity.Name;
            //var connectionID = Context.ConnectionId;
            //return base.OnConnectedAsync();
        //}
    }
}
