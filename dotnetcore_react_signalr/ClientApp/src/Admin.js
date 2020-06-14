import React, { useEffect, useState } from "react";
import {
    HubConnectionBuilder,
    LogLevel
} from "@microsoft/signalr";
import BarChart from './components/BarChart';

const Admin = () => {

    const [hubConnection, setHubConnection] = useState();
    const [usersPoints, setUsersPoints] = useState([]);
    const [category, setCategory] = useState('Test');

    const increaseData = async () => {
        try {
            var a = usersPoints.map(function (x) { return { name: x.name, points: x.points * 2 } });
            setUsersPoints(a);
        } catch (err) {
            console.log(err)
        }
    }

    const decreaseData = async () => {
        try {
            var a = usersPoints.map(function (x) { return { name: x.name, points: x.points / 2 } });
            setUsersPoints(a);
        } catch (err) {
            console.log(err)
        }
    }

    const addData = async () => {
        try {
            setUsersPoints(a => a.concat({ name: 'Gary', points: 50 }));
        } catch (err) {
            console.log(err)
        }
    }

    const getQuestions = async () => {
        try {
            await hubConnection.invoke("GetCategoryQuestions", category);
        } catch (err) {
            console.log(err)
        }
    }

    const clearSession = () => {
        try {
            hubConnection.invoke("ClearSession")
        } catch (err) {
            console.log(err)
        }
    }

    const resetPointsToZero = async () => {
        try {
            hubConnection.invoke("ResetPointsToZero")
        } catch (err) {
            console.log(err)
        }
    }

    const categoryChanged = (event) => {
        setCategory(event.target.value);
    }

    useEffect(() => {
        var password = window.prompt('Enter Password');
        if (password !== "quizmaster") {
        window.location = "/";
        }
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

            //connect.on('receiveMessage', (receivedMessage) => {
            //    setMessages(prevMsgs => prevMsgs.concat(receivedMessage));
            //    //receiveMessage2(receivedMessage, messages);
            //});

            connect.on('updateUsersPoints', (usersPoints) => {
                setUsersPoints(usersPoints);
            });

            setHubConnection(connect);
        }
        createHubConnection();
    }, []);

    return (
        <React.Fragment>
            <h1>Dave's Quiz Admin Page</h1>
            <div className="row">
                <ul className="actions">
                    <li>
                        <select id="category" onChange={categoryChanged} value={category}>
                            <option value="Test">Test</option>
                            <option value="Television">Television</option>
                            <option value="Football">Football</option>                            
                            <option value="Music">Music</option>
                            <option value="GeneralKnowledge">General Knowledge</option>
                            <option value="Prodigy">Prodigy</option>
                        </select>
                    </li>
                    <li>
                        <button onClick={getQuestions} className="button primary">Get Questions</button>
                    </li>
                    <li>
                        <button onClick={resetPointsToZero} className="button">Reset Points</button>
                    </li>
                    <li>
                        <button onClick={clearSession} className="button primary">Clear Session</button>
                    </li>
                </ul>
            </div>
            <div className="row">
                <div className="col-12">
                    <BarChart usersPoints={usersPoints} />
                </div>
            </div>
        </React.Fragment>
    );
}

export default Admin