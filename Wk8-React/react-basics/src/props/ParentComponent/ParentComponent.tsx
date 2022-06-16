import React from 'react'
import Button from '../ChildComponent/Button'

function ParentComponent() {
  return (
    <div>
        <Button color="red" isRound="true" onClick={() => {
            console.log("Red Button Clicked")
        }} text="Kevin's Button"/>

        <Button color="blue" isRound="false" onClick={() => {
            console.log("Blue button clicked")
        }} text="Blue Button"/>


        <Button color="green" isRound="true" onClick={() => {
            console.log("Green Button Clicks")
        }} text="Green Button"/>

        <h4>
          What is a Prop?
          <ul>
            <li>Stands for Properties</li>
            <li>Allows us to retrieve values from the parent component</li>
            <li>These values are readonly from the child side</li>
          </ul>
        </h4>
        <br />
        <h4>
          In this example we manipulated how these buttons look by passing values as props to the Button.tsx Component
        </h4>
    </div>
  )
}

export default ParentComponent