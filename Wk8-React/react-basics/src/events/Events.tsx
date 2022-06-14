import React from 'react'

function Events() {


    function clickHandler(){
        console.log("Button Clicked!")
    }

    const hoverHandler = () => {
        console.log("Button Hovered");
    }

    /* for any event, we can pass a variable to the function to get the event object
        event.target will get the element
        event.target.value will get value inside of the element
    */
    const inputHandler = (event : any) => {
        console.log(event.target.value)
    }

    // the attribute for events in react are camelCase.
    return (
        <>
            <button onClick={clickHandler}>Click Me</button>
            <button onMouseOver={hoverHandler}>Hover Me!</button>
            <input type="text" onChange={inputHandler}/>
        </>
    )
}

export default Events