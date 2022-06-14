import React from 'react'
import ComponentTwo from '../ComponentTwo/ComponentTwo'
import './ComponentOne.css'

/* 
    for styling, the className attribute is used instead of class

    "rfce" is the shortcut for creating a component
*/
function ComponentOne() {
  return (
    <div className='comp-one'>
        <h2>ComponentOne</h2>
        <ComponentTwo/>
        <ComponentTwo/>
        <ComponentTwo/>
    </div>
    
  )
}

export default ComponentOne