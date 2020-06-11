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
    const [questionData, setQuestionData] = useState('');
    
    const register = async () => {
        try {
            await hubConnection.invoke("RegisterSession", userName);
            setUserName('');
        } catch (err) {
            console.log(err)
        }
    }

    const submitAnswer = async (questionId, answerId) => {
        try {            
            console.log('submitting answer ' + answerId + ' to question ' + questionId);
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
                .configureLogging(LogLevel.Information)
                .build();
            try {
                await connect.start()
                //Invoke method defined in server to add user to a specified group
            } catch (err) {
                console.log(err)
            }
            
            connect.on('receiveQuestion', (receivedQuestion) => {
                setQuestionData(receivedQuestion);
                var timeleft = 9;
                var downloadTimer = setInterval(function () {
                    if (timeleft <= 0) {
                        clearInterval(downloadTimer);
                        document.getElementById("countdown").innerHTML = "Time's up!";
                    } else {
                        document.getElementById("countdown").innerHTML = timeleft + " seconds remaining";
                    }
                    timeleft -= 1;
                }, 1000);                
            });

            connect.on('updateUsersPoints', (usersPoints) => {
                setUsersPoints(usersPoints);
            });

            setHubConnection(connect);
        }
        createHubConnection();
    }, []);    

    return (
        <React.Fragment>
            <input type="text" value={userName} onChange={e => setUserName(e.target.value)} /><button onClick={register}>Register</button>         
            <div id="countdown"></div>
            <Question questionData={questionData} submitAnswer={submitAnswer} />
            <BarChart usersPoints={usersPoints} />            
        </React.Fragment>
    );

}

export default Quiz