import React from 'react'
const Question = (props) => {
    const data = props.questionData;
    const answerSubmitted = props.answerSubmitted;
    const setAnswerSubmitted = props.setAnswerSubmitted;
    const questionImage = "/assets/images/" + props.questionImage;

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
            <br />
            <div className="row">
                <div className="col-4">
                    <ul className="actions stacked">
                        {data.answers && !answerSubmitted && data.answers.map((answer, index) => {
                            return index % 2 === 0 ?
                                <React.Fragment>
                                    <li>
                                        <a key={index} href={null} onClick={submitAnswer.bind(this, answer.answerId)} className="button primary large">{answer.answerText}</a>
                                    </li>
                                </React.Fragment>
                                : <React.Fragment>
                                    <li>
                                        <a key={index} href={null} onClick={submitAnswer.bind(this, answer.answerId)} className="button large">{answer.answerText}</a>
                                    </li>
                                </React.Fragment>
                        })}
                    </ul>
                </div>
                <div className="col-8">
                    <span className="image fit"><img src={questionImage} alt="" /></span>
                </div>
            </div>
            <br />
        </React.Fragment>
    )
}
export default Question