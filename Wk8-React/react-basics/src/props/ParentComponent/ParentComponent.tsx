import React from 'react'
import Button from '../ChildComponent/Button'

function ParentComponent() {
  return (
    <div>
        <Button color="red"/>
        <Button color="blue"/>
        <Button color="green"/>
    </div>
  )
}

export default ParentComponent