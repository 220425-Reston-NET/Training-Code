import { isVisible } from '@testing-library/user-event/dist/utils';
import React, { useEffect, useState } from 'react'

function Hooks() {

    /* 
        What is a hook?
            - hooks are methods added for functional components to be able to have all the ability that class components have

        Hooks we will be looking at:
            - useState()
                - allows us to create state variables
            - useEffect()
                - function is called anytime the function renders
                - AND we can monitor variables with it

        What is state?
            - variables that are directly tied to the component
    
    */

    /* const [isVisible, setVisibility] = useState(true);

    const [counter, setCounter] = useState(0); */

    const [state, setState] = useState({
        isVisible: true,
        counter : 0,
        text: ""
    });

    /* useEffect allows us to run a function when the component is first rendered */
    useEffect(() => {
        console.log("Component rendered");
    }, []);


    //anytime state changes, this function will be ran
    useEffect(() => {
        console.log(state);
    }, [state])



    function toggleDiv(){
        //setVisibility(!isVisible);

        //...variable is a quick way to make a copy of an object or array
        setState({...state, isVisible: !state.isVisible})
    }

    function incrementCounter(){
        //setCounter(counter + 1);
        setState({...state, counter: state.counter + 1})
    }

    function updateText(event : any){
        setState({...state, text: event.target.value});
    }

    return (
        <>
            {
                state.isVisible ? <h2>Hello World!</h2> : <></>
            }
            <button onClick={toggleDiv}>Toggle!</button>

            <div>{state.counter}</div>
            <button onClick={incrementCounter}>Increment</button>

            <input type="text" onChange={updateText} />
            <h2>{state.text}</h2>
        </>
    )
}

export default Hooks