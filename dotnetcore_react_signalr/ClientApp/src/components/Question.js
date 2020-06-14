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
            <div className="row">
                <div className="col-12">
                    <h3>{data.questionText}</h3>
                </div>
            </div>
            <br/>
            <div className="row">
                <ul className="actions stacked">
                {data.answers && !answerSubmitted && data.answers.map((answer, index) => {
                    return index % 2 === 0 ?
                        <React.Fragment>
                            <li>
                                <a key={index} href="#" onClick={submitAnswer.bind(this, answer.answerId)} className="button primary large">{answer.answerText}</a>
                            </li>
                        </React.Fragment>
                        : <React.Fragment>
                            <li>
                                <a key={index} href="#" onClick={submitAnswer.bind(this, answer.answerId)} className="button large">{answer.answerText}</a>
                            </li>
                        </React.Fragment>
                })}
                </ul>
            </div>
            <br/>
        </React.Fragment>
    )
}
export default Question