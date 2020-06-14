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
                                new AnswerModel { AnswerId = 3, AnswerText = "Four" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Eight" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Ten" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Eleven" }
                            },
                            CorrectAnswerId = 3
                        },
                        new QuestionModel {
                            QuestionId = 2,
                            QuestionText = "What is 7 + 1?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Eight" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Ten" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Twenty" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Nine" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Thirteen" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Fifty" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 3,
                            QuestionText = "What is 2 x 6?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Seven" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Three" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Twelve" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Ten" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Sixteen" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Ninety One" }
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
                                new AnswerModel { AnswerId = 3, AnswerText = "Channel 4" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Channel 5" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Channel 6" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Channel 7" }
                            },
                            CorrectAnswerId = 3
                        },
                        new QuestionModel {
                            QuestionId = 2,
                            QuestionText = "What is 7 + 1?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Eight" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Ten" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Twenty" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Channel 5" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Channel 6" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Channel 7" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 3,
                            QuestionText = "What is 2 x 6?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Seven" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Three" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Twelve" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Channel 5" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Channel 6" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Channel 7" }
                            },
                            CorrectAnswerId = 3
                        },

                    }
                }
            };
        }
    }
}
