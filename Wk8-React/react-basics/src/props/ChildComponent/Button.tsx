import React from 'react'
import './Button.css'
/* 
    What are props?
        - stands for properties
        - allows us to retrieve values from the parent component

*/
function Button(props : any) {
  return (
    <button className="child-btn" style={{backgroundColor: props.color}}>Button</button>
  )
}

export default Button