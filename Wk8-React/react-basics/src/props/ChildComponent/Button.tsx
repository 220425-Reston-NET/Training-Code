import React from 'react'
import './Button.css'
/* 
    What are props?
        - stands for properties
        - allows us to retrieve values from the parent component
        - read only from the child side

*/

//we are retrieving the background color, border radius and click event from the parent passed as props
function Button(props : any) {
    return (
        <button className="child-btn" style={{
            backgroundColor: props.color, 
            borderRadius: props.isRound === "true" ? "8px" : "0px"
        }} onClick={props.onClick}>{props.text}</button>
    )
}

export default Button