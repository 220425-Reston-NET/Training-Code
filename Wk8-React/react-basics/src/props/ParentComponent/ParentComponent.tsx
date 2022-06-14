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
    </div>
  )
}

export default ParentComponent