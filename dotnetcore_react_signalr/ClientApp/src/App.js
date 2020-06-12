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
    
    const register = async () => {
        try {
            await hubConnection.invoke("RegisterSession", userName);
            setUserName('');
            setIsRegistered(true);
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
            
            connect.on('receiveQuestion', (category, receivedQuestion) => {                
                setAnswerSubmitted(false);
                setCategory(`It's the ${category} round!`);
                setQuestionCount(`    Here comes question ${receivedQuestion.questionId} of 10...`);
                setQuestionData(receivedQuestion);
                var timeleft = 9;
                var downloadTimer = setInterval(function () {
                    if (timeleft <= 0) {
                        clearInterval(downloadTimer);
                        var finalText = receivedQuestion.questionId === 3 ? "" : "Time's up!"; 
                        document.getElementById("countdown").innerHTML = finalText;
                    } else {
                        document.getElementById("countdown").innerHTML = "    You have " + timeleft + " seconds left to answer...";
                    }
                    timeleft -= 1;
                }, 1000);                
            });

            connect.on('updateUsersPoints', (usersPoints) => {
                setUsersPoints(usersPoints);
            });

            connect.on('roundComplete', (category) => {
                setCategory(`And that completes the ${category} round!`);
                setQuestionCount('');
                setQuestionData({ questionText: "    Let's take a look at the scores..." });                
            });

            setHubConnection(connect);
        }
        createHubConnection();
    }, []);    

    if (!isRegistered) {
        return (
            <React.Fragment >
                <input type="text" value={userName} onChange={e => setUserName(e.target.value)} maxLength="10" /><button onClick={register}>Register</button>
                <BarChart usersPoints={usersPoints} />
            </React.Fragment >
        );
    } else {
        return (
            <React.Fragment >
                <label id="questionHeader"><strong>{category}</strong>{questionCount}</label><em><span id="countdown"></span></em>
                <Question questionData={questionData} submitAnswer={submitAnswer} answerSubmitted={answerSubmitted} setAnswerSubmitted={setAnswerSubmitted} />
                <BarChart usersPoints={usersPoints} />
            </React.Fragment >
        );
    }
}

export default Quiz