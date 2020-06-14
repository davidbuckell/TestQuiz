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
                            QuestionText = "On TV show Strike it lucky, how many TV screens where there in total?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "10" },
                                new AnswerModel { AnswerId = 2, AnswerText = "15" },
                                new AnswerModel { AnswerId = 3, AnswerText = "20" },
                                new AnswerModel { AnswerId = 4, AnswerText = "25" },
                                new AnswerModel { AnswerId = 5, AnswerText = "30" },
                                new AnswerModel { AnswerId = 6, AnswerText = "35" }
                            },
                            CorrectAnswerId = 5
                        },
                        new QuestionModel {
                            QuestionId = 2,
                            QuestionText = "What were the names of the twins on Fun House?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Mel & Sue" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Kelly & Jessica" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Jane & Rebecca" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Melanie & Martina" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Tina & Tracey" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Melanie & Lucy" }
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 3,
                            QuestionText = "Ross King presented the 'what' from manchester?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "8:00" },
                                new AnswerModel { AnswerId = 2, AnswerText = "8:15" },
                                new AnswerModel { AnswerId = 3, AnswerText = "8:30" },
                                new AnswerModel { AnswerId = 4, AnswerText = "8:45" },
                                new AnswerModel { AnswerId = 5, AnswerText = "9:00" },
                                new AnswerModel { AnswerId = 6, AnswerText = "9:15" }
                            },
                            CorrectAnswerId = 2
                        },
                        new QuestionModel {
                            QuestionId = 4,
                            QuestionText = "In the first series of friends, where the two apartment numbers?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "4 & 5" },
                                new AnswerModel { AnswerId = 2, AnswerText = "6 & 7" },
                                new AnswerModel { AnswerId = 3, AnswerText = "8 & 9" },
                                new AnswerModel { AnswerId = 4, AnswerText = "10 & 11" },
                                new AnswerModel { AnswerId = 5, AnswerText = "19 & 20" },
                                new AnswerModel { AnswerId = 6, AnswerText = "22 & 23" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 5,
                            QuestionText = "Who has not presented childrens tv show the broom cupboard?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Andy Crane" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Andi Peters" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Simon Parkin" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Phillipa Forrester" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Philip Schofield" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Dave Benson Phillips" }
                            },
                            CorrectAnswerId = 6
                        },
                        new QuestionModel {
                            QuestionId = 6,
                            QuestionText = "What was the first name of boy who became bananaman?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Pete" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Andy" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Jamie" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Eric" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Ernie" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Christopher" }
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 7,
                            QuestionText = "Which character was Jessie from saved by the bell?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "A" },
                                new AnswerModel { AnswerId = 2, AnswerText = "B" },
                                new AnswerModel { AnswerId = 3, AnswerText = "C" },
                                new AnswerModel { AnswerId = 4, AnswerText = "D" },
                                new AnswerModel { AnswerId = 5, AnswerText = "E" },
                                new AnswerModel { AnswerId = 6, AnswerText = "F" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 8,
                            QuestionText = "What was the name of this character?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Ernie" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Gilbert" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Eric" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Doug" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Stan" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Harry" }
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 9,
                            QuestionText = "How many episodes of Beavis & Butthead were made?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "157" },
                                new AnswerModel { AnswerId = 2, AnswerText = "204" },
                                new AnswerModel { AnswerId = 3, AnswerText = "252" },
                                new AnswerModel { AnswerId = 4, AnswerText = "297" },
                                new AnswerModel { AnswerId = 5, AnswerText = "302" },
                                new AnswerModel { AnswerId = 6, AnswerText = "315" }
                            },
                            CorrectAnswerId = 3
                        },
                        new QuestionModel {
                            QuestionId = 10,
                            QuestionText = "How many episodes of Top of the Pops were aired?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "1002" },
                                new AnswerModel { AnswerId = 2, AnswerText = "1265" },
                                new AnswerModel { AnswerId = 3, AnswerText = "1784" },
                                new AnswerModel { AnswerId = 4, AnswerText = "2182" },
                                new AnswerModel { AnswerId = 5, AnswerText = "2267" },
                                new AnswerModel { AnswerId = 6, AnswerText = "2834" }
                            },
                            CorrectAnswerId = 5
                        },
                    }
                },
                {
                    QuizCategory.GeneralKnowledge, new List<QuestionModel>() {
                        new QuestionModel {
                            QuestionId = 1,
                            QuestionText = "Which year was the internet launched?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "1990" },
                                new AnswerModel { AnswerId = 2, AnswerText = "1991" },
                                new AnswerModel { AnswerId = 3, AnswerText = "1992" },
                                new AnswerModel { AnswerId = 4, AnswerText = "1993" },
                                new AnswerModel { AnswerId = 5, AnswerText = "1994" },
                                new AnswerModel { AnswerId = 6, AnswerText = "1995" }
                            },
                            CorrectAnswerId = 3
                        },
                        new QuestionModel {
                            QuestionId = 2,
                            QuestionText = "Which lynx scent was not included in the original product launch?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Africa" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Amber" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Musk" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Spice" },
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 3,
                            QuestionText = "What was the name of these minty opal fruit type sweets?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Minties" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Mintburst" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Chewies" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Pacers" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Opals" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Green Chews" }
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 4,
                            QuestionText = "Which year did Cafe Mambo open in ibiza?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "1990" },
                                new AnswerModel { AnswerId = 2, AnswerText = "1991" },
                                new AnswerModel { AnswerId = 3, AnswerText = "1992" },
                                new AnswerModel { AnswerId = 4, AnswerText = "1993" },
                                new AnswerModel { AnswerId = 5, AnswerText = "1994" },
                                new AnswerModel { AnswerId = 6, AnswerText = "1995" }
                            },
                            CorrectAnswerId = 5
                        },
                        new QuestionModel {
                            QuestionId = 5,
                            QuestionText = "What was the name of these chewy toffee sweets?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Toffo" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Toffee" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Toffets" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Chews" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Chewies" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Toffee Chews" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 6,
                            QuestionText = "On average, how many tic tacs were in a box?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "30" },
                                new AnswerModel { AnswerId = 2, AnswerText = "33" },
                                new AnswerModel { AnswerId = 3, AnswerText = "35" },
                                new AnswerModel { AnswerId = 4, AnswerText = "38" },
                                new AnswerModel { AnswerId = 5, AnswerText = "41" },
                                new AnswerModel { AnswerId = 6, AnswerText = "43" }
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 7,
                            QuestionText = "Which company produced Scampi Fries?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Walkers" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Smiths" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Ruffles" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Salt 'n' Shake" },
                                new AnswerModel { AnswerId = 5, AnswerText = "KP" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Golden Wonder" }
                            },
                            CorrectAnswerId = 2
                        },
                        new QuestionModel {
                            QuestionId = 8,
                            QuestionText = "Which year was Slinky launched in Boscombe's Opera House?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "1992" },
                                new AnswerModel { AnswerId = 2, AnswerText = "1993" },
                                new AnswerModel { AnswerId = 3, AnswerText = "1994" },
                                new AnswerModel { AnswerId = 4, AnswerText = "1995" },
                                new AnswerModel { AnswerId = 5, AnswerText = "1996" },
                                new AnswerModel { AnswerId = 6, AnswerText = "1997" }
                            },
                            CorrectAnswerId = 6
                        },
                        new QuestionModel {
                            QuestionId = 9,
                            QuestionText = "What was the name of the Hofmeister bear?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Gary" },
                                new AnswerModel { AnswerId = 2, AnswerText = "George" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Geoff" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Grizzly" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Greg" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Graham" }
                            },
                            CorrectAnswerId = 2
                        },
                        new QuestionModel {
                            QuestionId = 10,
                            QuestionText = "eBay launched in 1995 under what name?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "ePay" },
                                new AnswerModel { AnswerId = 2, AnswerText = "eBuy" },
                                new AnswerModel { AnswerId = 3, AnswerText = "AuctionWeb" },
                                new AnswerModel { AnswerId = 4, AnswerText = "eAuction" },
                                new AnswerModel { AnswerId = 5, AnswerText = "eBid" },
                                new AnswerModel { AnswerId = 6, AnswerText = "BuySellZone" }
                            },
                            CorrectAnswerId = 3
                        },
                    }
                },
                {
                    QuizCategory.Music, new List<QuestionModel>() {
                        new QuestionModel {
                            QuestionId = 1,
                            QuestionText = "What did jinny encourage us to do in 1995?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Keep Moving" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Keep Dancing" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Keep Jumpin" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Keep Warm" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Keep Flexing" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Keep Drinking" }
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 2,
                            QuestionText = "You sang You Sure Do in 1994?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Strike" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Spike" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Clubbers" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Dubbers" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Icthers" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Scratchers" },
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 3,
                            QuestionText = "Where did the Backstreet Boys take their name from?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Childhood gang name" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Favourite sports team" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Flea Market" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Fast food takeaway" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Cleaning company" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Local gym" }
                            },
                            CorrectAnswerId = 3
                        },
                        new QuestionModel {
                            QuestionId = 4,
                            QuestionText = "In 1992 we were introduced to Chaka Demus & Pliers. Which one was Pliers?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "A" },
                                new AnswerModel { AnswerId = 2, AnswerText = "B" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 5,
                            QuestionText = "Who had the most christmas number 1's?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Westlife" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Michael Jackson" },
                                new AnswerModel { AnswerId = 3, AnswerText = "East 17" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Cliff Richard" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Spice Girls" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Mariah Carey" }
                            },
                            CorrectAnswerId = 5
                        },
                        new QuestionModel {
                            QuestionId = 6,
                            QuestionText = "Which nationality were the Crash Test Dummies?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "British" },
                                new AnswerModel { AnswerId = 2, AnswerText = "American" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Canadian" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Spanish" },
                                new AnswerModel { AnswerId = 5, AnswerText = "French" },
                                new AnswerModel { AnswerId = 6, AnswerText = "German" }
                            },
                            CorrectAnswerId = 3
                        },
                        new QuestionModel {
                            QuestionId = 7,
                            QuestionText = "Who can forget Charles & Eddie, but which one was Eddie?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "A" },
                                new AnswerModel { AnswerId = 2, AnswerText = "B" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Neither" }
                            },
                            CorrectAnswerId = 2
                        },
                        new QuestionModel {
                            QuestionId = 8,
                            QuestionText = "Kriss Kross released Jump in which year?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "1992" },
                                new AnswerModel { AnswerId = 2, AnswerText = "1993" },
                                new AnswerModel { AnswerId = 3, AnswerText = "1994" },
                                new AnswerModel { AnswerId = 4, AnswerText = "1995" },
                                new AnswerModel { AnswerId = 5, AnswerText = "1996" },
                                new AnswerModel { AnswerId = 6, AnswerText = "1997" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 9,
                            QuestionText = "How many times did Meredith Brooks insist she was bitch during hit single?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "2" },
                                new AnswerModel { AnswerId = 2, AnswerText = "4" },
                                new AnswerModel { AnswerId = 3, AnswerText = "6" },
                                new AnswerModel { AnswerId = 4, AnswerText = "8" },
                                new AnswerModel { AnswerId = 5, AnswerText = "10" },
                                new AnswerModel { AnswerId = 6, AnswerText = "12" }
                            },
                            CorrectAnswerId = 2
                        },
                        new QuestionModel {
                            QuestionId = 10,
                            QuestionText = "Tunde Baiyewu was the lead singer of which group?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "2Unlimited" },
                                new AnswerModel { AnswerId = 2, AnswerText = "The Grid" },
                                new AnswerModel { AnswerId = 3, AnswerText = "M People" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Heaven 17" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Shakespears Sister" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Lighthouse Family" }
                            },
                            CorrectAnswerId = 6
                        },
                    }
                },
                {
                    QuizCategory.Football, new List<QuestionModel>() {
                        new QuestionModel {
                            QuestionId = 1,
                            QuestionText = "Which year did AFC Bournemouth play at Wembley?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "1993" },
                                new AnswerModel { AnswerId = 2, AnswerText = "1994" },
                                new AnswerModel { AnswerId = 3, AnswerText = "1995" },
                                new AnswerModel { AnswerId = 4, AnswerText = "1996" },
                                new AnswerModel { AnswerId = 5, AnswerText = "1997" },
                                new AnswerModel { AnswerId = 6, AnswerText = "1998" }
                            },
                            CorrectAnswerId = 6
                        },
                        new QuestionModel {
                            QuestionId = 2,
                            QuestionText = "Which country did not compete at Euro 96?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "England" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Sweden" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Switzerland" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Netherlands" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Scotland" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Romania" },
                            },
                            CorrectAnswerId = 2
                        },
                        new QuestionModel {
                            QuestionId = 3,
                            QuestionText = "Which team won the FA Cup the most times during the nineties?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Arsenal" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Chelsea" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Manchester United" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Everton" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Liverpool" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Tottenham Hotspur" }
                            },
                            CorrectAnswerId = 3
                        },
                        new QuestionModel {
                            QuestionId = 4,
                            QuestionText = "Which team did not win the FA Cup during the nineties?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Arsenal" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Chelsea" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Manchester City" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Everton" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Liverpool" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Tottenham Hotspur" }
                            },
                            CorrectAnswerId = 3
                        },
                        new QuestionModel {
                            QuestionId = 5,
                            QuestionText = "Who managed the most amount of AFC Bournemouth matches during the nineties?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Harry Redknapp" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Tony Pulis" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Sean O'Driscoll" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Mel Machin" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Eddie Howe" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Jimmy Quinn" }
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 6,
                            QuestionText = "Who was the main presenter of Match of the Day during the nineties?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Gary Lineker" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Ray Stubbs" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Jimmy Hill" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Des Lynam" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Trevor Brooking" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Jimmy Greaves" }
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 7,
                            QuestionText = "Who has never represented AFC Bournemouth?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Rio Ferdinand" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Ryan Giggs" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Jamie Redknapp" },
                                new AnswerModel { AnswerId = 4, AnswerText = "David Beckham" }
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 8,
                            QuestionText = "In 1993 which striker was transferred from Bournemouth to Norwich?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Efan Ekoku" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Luther Blissett" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Steve Fletcher" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Mark Stein" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Jermain Defoe" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Steve Cotterill" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 9,
                            QuestionText = "Which British player has never professionally played in Italy?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "David Platt" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Paul Gascoigne" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Des Walker" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Paul Ince" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Bryan Robson" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Aaron Ramsey" },
                            },
                            CorrectAnswerId = 5
                        },
                        new QuestionModel {
                            QuestionId = 10,
                            QuestionText = "Which country won Euro 92?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Denmark" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Sweden" },
                                new AnswerModel { AnswerId = 3, AnswerText = "England" },
                                new AnswerModel { AnswerId = 4, AnswerText = "France" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Germany" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Spain" }
                            },
                            CorrectAnswerId = 1
                        },
                    }
                },
                {
                    QuizCategory.Prodigy, new List<QuestionModel>() {
                        new QuestionModel {
                            QuestionId = 1,
                            QuestionText = "Approximately how many people watched Prodigy's first gig?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "20" },
                                new AnswerModel { AnswerId = 2, AnswerText = "50" },
                                new AnswerModel { AnswerId = 3, AnswerText = "100" },
                                new AnswerModel { AnswerId = 4, AnswerText = "200" },
                                new AnswerModel { AnswerId = 5, AnswerText = "500" },
                                new AnswerModel { AnswerId = 6, AnswerText = "1000" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 2,
                            QuestionText = "What was their first released EP called?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Out of Space" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Charly" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Poison" },
                                new AnswerModel { AnswerId = 4, AnswerText = "What Evil Lurks" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Jericho" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Breathe" },
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 3,
                            QuestionText = "Fat of the Land was releasd in 1997. How many UK copies sold in the first week?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "100k" },
                                new AnswerModel { AnswerId = 2, AnswerText = "150k" },
                                new AnswerModel { AnswerId = 3, AnswerText = "215k" },
                                new AnswerModel { AnswerId = 4, AnswerText = "317k" },
                                new AnswerModel { AnswerId = 5, AnswerText = "409k" },
                                new AnswerModel { AnswerId = 6, AnswerText = "500k" }
                            },
                            CorrectAnswerId = 4
                        },
                        new QuestionModel {
                            QuestionId = 4,
                            QuestionText = "In 1998 which band requested Prodigy were removed from Reading Festival lineup?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Pet Shop Boys" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Stereophonics" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Muse" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Metallica" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Rage against the machine" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Beastie Boys" }
                            },
                            CorrectAnswerId = 6
                        },
                        new QuestionModel {
                            QuestionId = 5,
                            QuestionText = "Lyrics to Out of Space were sampled from which reggae act?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Bob Marley" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Max Romeo" },
                                new AnswerModel { AnswerId = 3, AnswerText = "UB40" },
                                new AnswerModel { AnswerId = 4, AnswerText = "PM Dawn" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Steel Pulse" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Culture" }
                            },
                            CorrectAnswerId = 2
                        },
                        new QuestionModel {
                            QuestionId = 6,
                            QuestionText = "The band once had a 3rd dancer. What was their name?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Sharky" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Sparky" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Spunky" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Spinky" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Spooky" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Splosh" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 7,
                            QuestionText = "Voodoo people guitar rift was sampled from which band?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Nirvana" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Green Day" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Stone Temple Pilots" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Foo Fighters" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 8,
                            QuestionText = "What was the bands original record label?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Azuli Records" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Little Helpers" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Pets Recordings" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Phantasy" },
                                new AnswerModel { AnswerId = 5, AnswerText = "XL" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Critical Music" }
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 9,
                            QuestionText = "What was the name of their first UK chart hit?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "Charly" },
                                new AnswerModel { AnswerId = 2, AnswerText = "Out of Space" },
                                new AnswerModel { AnswerId = 3, AnswerText = "Firestarter" },
                                new AnswerModel { AnswerId = 4, AnswerText = "Poison" },
                                new AnswerModel { AnswerId = 5, AnswerText = "Breathe" },
                                new AnswerModel { AnswerId = 6, AnswerText = "Jericho" },
                            },
                            CorrectAnswerId = 1
                        },
                        new QuestionModel {
                            QuestionId = 10,
                            QuestionText = "How many studio albums have they produced?",
                            Answers = new List<AnswerModel> {
                                new AnswerModel { AnswerId = 1, AnswerText = "4" },
                                new AnswerModel { AnswerId = 2, AnswerText = "5" },
                                new AnswerModel { AnswerId = 3, AnswerText = "6" },
                                new AnswerModel { AnswerId = 4, AnswerText = "7" },
                                new AnswerModel { AnswerId = 5, AnswerText = "8" },
                                new AnswerModel { AnswerId = 6, AnswerText = "9" }
                            },
                            CorrectAnswerId = 4
                        },
                    }
                }
            };
        }
    }
}
