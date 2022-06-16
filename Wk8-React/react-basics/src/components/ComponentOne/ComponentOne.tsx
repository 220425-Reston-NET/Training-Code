import React from 'react'
import ComponentTwo from '../ComponentTwo/ComponentTwo'
import './ComponentOne.css'

/* 
    for styling, the className attribute is used instead of class

    "rfce" is the shortcut for creating a component
*/
function ComponentOne() {
  return (
    <>
      
      <div className='comp-one'>
          <h2>ComponentOne</h2>
          <ComponentTwo/>
          <ComponentTwo/>
          <ComponentTwo/>
      </div>

      <h4>
          What is a Component?
          <ul>
            <li>A component is a snippet of HTML, CSS and JavaScript</li>
            <li>They are the building blocks oh react applications</li>
            <li>The parent component of all components is the App Component</li>
          </ul>
        </h4>
      <br />
      <h4>
      Components are reusable so this is a great benefit of React. We can see in this example that ComponentOne has 3 children componentTwos
      </h4>
      <br />
      <h4>
      Shortcut for creating a component is "rfce"
      </h4>
      
    </>
    
  )
}

export default ComponentOne