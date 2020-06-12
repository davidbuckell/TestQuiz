import React from 'react'
const Question = (props) => {
    const data = props.questionData;
    const answerSubmitted = props.answerSubmitted;
    const setAnswerSubmitted = props.setAnswerSubmitted;

    function submitAnswer(option) {
        setAnswerSubmitted(true);
        props.submitAnswer(data.questionId, option);
    }

    return (
        <React.Fragment>
            <p>{data.questionText}</p>
            {data.answers && !answerSubmitted && data.answers.map((answer, index) => (
                <button key={index} onClick={submitAnswer.bind(this, answer.answerId)}>{answer.answerText}</button>                
            ))}
        </React.Fragment>
    )
}
export default Question