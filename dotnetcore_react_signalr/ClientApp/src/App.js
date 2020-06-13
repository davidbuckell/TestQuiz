import React, { useEffect, useState } from "react";
import {
    HubConnectionBuilder,
    LogLevel
} from "@microsoft/signalr";
import BarChart from './components/BarChart';
import Question from './components/Question';

const Quiz = () => {

    const [hubConnection, setHubConnection] = useState();
    const [userName, setUserName] = useState('');
    const [usersPoints, setUsersPoints] = useState([]);
    const [category, setCategory] = useState('');
    const [questionCount, setQuestionCount] = useState('Get ready, the quiz is about to start!');
    const [questionData, setQuestionData] = useState('');
    const [isRegistered, setIsRegistered] = useState(false);
    const [answerSubmitted, setAnswerSubmitted] = useState(false);
    const [correctAnswer, setCorrectAnswer] = useState('');
    const [activeQuestion, setActiveQuestion] = useState(false);

    const register = async () => {
        try {
            var registered = await hubConnection.invoke("RegisterSession", userName);
            if (registered) {
                setUserName('');
                setIsRegistered(true);
            }
            else {
                document.getElementById('registerLabel').innerText = "Username already taken, enter another:"
            }
        } catch (err) {
            console.log(err)
        }
    }

    const submitAnswer = async (questionId, answerId) => {
        try {
            await hubConnection.invoke("SubmitAnswer", "Television", questionId, answerId)
        } catch (err) {
            console.log(err)
        }
    }

    useEffect(() => {
        const createHubConnection = async () => {
            const connect = new HubConnectionBuilder()
                .withUrl("/quizHub", {

                })
                .withAutomaticReconnect()
                .configureLogging(LogLevel.Information)
                .build();
            try {
                await connect.start()
                //Invoke method defined in server to add user to a specified group
            } catch (err) {
                console.log(err)
            }

            connect.on('receiveQuestion', (category, receivedQuestion, questionsCount) => {
                setCorrectAnswer('');
                setActiveQuestion(true);
                setAnswerSubmitted(false);
                setCategory(`It's the ${category} round!`);
                setQuestionCount(`    Here comes question ${receivedQuestion.questionId} of ${questionsCount}...`);
                setQuestionData(receivedQuestion);
                var timeleft = 9;
                var downloadTimer = setInterval(function () {
                    if (timeleft <= 0) {
                        clearInterval(downloadTimer);
                        var finalText = receivedQuestion.questionId === questionCount ? "" : "Time's up!";
                        document.getElementById("countdown").innerHTML = finalText;
                        setAnswerSubmitted(true);
                    } else {
                        document.getElementById("countdown").innerHTML = "    You have " + timeleft + " seconds left to answer...";
                    }
                    timeleft -= 1;
                }, 1000);
            });

            connect.on('displayAnswer', (correctAnswer) => {
                setCorrectAnswer(`And the correct answer was ${correctAnswer}!`);
            });

            connect.on('updateUsersPoints', (usersPoints) => {
                setUsersPoints(usersPoints);
            });

            connect.on('roundComplete', (category) => {
                setCorrectAnswer('');
                setActiveQuestion(false);
                setCategory(`And that completes the ${category} round!`);
                setQuestionCount("Let's take a look at the scores...");
            });

            setHubConnection(connect);
        }
        createHubConnection();
    }, []);

    if (!isRegistered) {
        return (
            <React.Fragment>
                <div className="row">
                    <div className="col-5">
                        <h3 id="registerLabel">Enter your username:</h3>
                    </div>
                    <div className="col-5">
                        <input type="text" value={userName} onChange={e => setUserName(e.target.value)} maxLength="10" />
                    </div>
                    <div className="col-2">
                        <button onClick={register} className="button primary">Register</button>
                    </div>
                </div>
                <div className="row">
                    <div className="col-12">
                        <BarChart usersPoints={usersPoints} />
                    </div>
                </div>
            </React.Fragment>
        );
    } else {
        return (
            <React.Fragment>
                <div className="row">
                    <div className="col-12">
                        <h3 id="questionHeader"><strong>{category}</strong></h3>
                        <h4>{questionCount}</h4>
                        <hr />
                    </div>
                    {activeQuestion ? (
                        <React.Fragment>
                            <div className="col-12">
                                <Question questionData={questionData} submitAnswer={submitAnswer} answerSubmitted={answerSubmitted} setAnswerSubmitted={setAnswerSubmitted} />
                                <h4 id="correctAnswer">{correctAnswer}</h4>
                            </div>
                            <div className="col-12">
                                <hr />
                                <h6><em><span id="countdown"></span></em></h6>
                                <hr />
                            </div>
                        </React.Fragment>
                    ) : ("")}
                </div>
                <div className="row">
                    <div className="col-12">
                        <BarChart usersPoints={usersPoints} />
                    </div>
                </div>
            </React.Fragment>
        );
    }
}

export default Quiz