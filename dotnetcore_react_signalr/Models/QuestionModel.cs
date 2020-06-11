using System.Collections.Generic;

namespace dotnetcore_react_signalr.Models
{
    public class QuestionModel
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public IEnumerable<AnswerModel> Answers{ get; set; }
        public int CorrectAnswerId { get; set; }
    }
}
