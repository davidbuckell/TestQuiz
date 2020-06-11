import React, { useState } from 'react'
const Question = (props) => {
    const data = props.questionData;

    function submitAnswer(option) {
        console.log('clicked ' + option);
        props.submitAnswer(data.questionId, option);
    }

    console.log('question data is ' + JSON.stringify(data));

    return (
        <React.Fragment>
            <p>{data.questionText}</p>
            {data.answers && data.answers.map((answer, index) => (
                <button key={index} onClick={submitAnswer.bind(this, answer.answerId)}>{answer.answerText}</button>                
            ))}
        </React.Fragment>
    )
}
export default Question