using dotnetcore_react_signalr.Enums;
using dotnetcore_react_signalr.Models;
using System.Collections.Generic;

namespace dotnetcore_react_signalr.Helpers
{
    public static class QuestionsHelper
    {
        public static Dictionary<QuizCategory, List<QuestionModel>> GetAllQuestions()
        {
            return new Dictionary<QuizCategory, List<QuestionModel>>()
            {
                {
                    QuizCategory.Test, new List<QuestionModel>() {
                        new QuestionModel {
                            QuestionId = 1,
                            QuestionText = "What is 2 + 2?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Three" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Seven" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Four" }
                            },
                            CorrectAnswerId = 3
                        },
                        new QuestionModel {
                            QuestionId = 2,
                            QuestionText = "What is 7 + 1?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Eight" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Ten" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Twenty" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 3,
                            QuestionText = "What is 2 x 6?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Seven" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Three" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Twelve" }
                            },
                            CorrectAnswerId = 3
                        },

                    }
                },
                {
                    QuizCategory.Television, new List<QuestionModel>() {
                        new QuestionModel {
                            QuestionId = 1,
                            QuestionText = "Whic channel is best?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "BBC" },
                                new AnswerModel { AnswerId = 2, AnswerText = "ITV" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Channel 4" }
                            },
                            CorrectAnswerId = 3
                        },
                        new QuestionModel {
                            QuestionId = 2,
                            QuestionText = "What is 7 + 1?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Eight" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Ten" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Twenty" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 3,
                            QuestionText = "What is 2 x 6?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Seven" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Three" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Twelve" }
                            },
                            CorrectAnswerId = 3
                        },

                    }
                }
            };
        }
    }
}
