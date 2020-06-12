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
            <button onClick={increaseData}>Increase</button>
            <button onClick={decreaseData}>Decrease</button>
            <button onClick={addData}>Add</button>
            <select id="category" onChange={categoryChanged} value={category}>
                <option value="Test">Test</option>
                <option value="Television">Television</option>
                <option value="GeneralKnowledge">General Knowledge</option>
                <option value="Music">Music</option>
                <option value="Football">Football</option>
                <option value="WhichOnesJeff">Which Ones Jeff</option>                
            </select>
            <button onClick={getQuestions}>Get Question</button>
            <button onClick={resetPointsToZero}>Reset Points</button>
            <button onClick={clearSession}>Clear Session</button>
            <BarChart usersPoints={usersPoints} />
        </React.Fragment>
    );
}

export default Admin