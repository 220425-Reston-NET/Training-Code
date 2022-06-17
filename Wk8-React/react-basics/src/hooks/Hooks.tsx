import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux';
import { counterActions } from '../redux/slices/counterSlice';

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

    const counter = useSelector((state : any) => state.counter.value);

    const dispatch = useDispatch();

    const [state, setState] = useState({
        isVisible: true,
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
        //setState({...state, counter: state.counter + 1})
        dispatch(counterActions.increment());
    }

    function updateText(event : any){
        setState({...state, text: event.target.value});
    }

    return (
        <>
            {
                state.isVisible ? <h2 data-testid="hello-world">Hello World!</h2> : <></>
            }
            <button data-testid="toggle-btn" onClick={toggleDiv}>Toggle!</button>

            <div data-testid="counter-div">{counter}</div>
            <button data-testid="increment-btn" onClick={incrementCounter}>Increment</button>

            <input data-testid="text-input" type="text" onChange={updateText} />
            <h2 data-testid="text-h2">{state.text}</h2>

            <h4>
                What is a Hook?
                <ul>
                    <li>Hooks are methods added for functional components to be able to have all the abilities that class components have</li>
                    <li>There are two hooks we will be looking at:
                        <ul>
                            <li>useState()</li>
                            <ul>
                                <li>useState allows us to create state variables with functional components</li>
                                <li>in this example the state variables we are monitoring are state.isVisible and state.counter</li>
                                <ul>
                                    <li>Anytime those values change, the component rerenders with correct values</li>
                                </ul>
                            </ul>
                            <li>useEffect()</li>
                            <ul>
                                <li>useEffect is a function that can be called when the component first renders</li>
                                <li>the function can also be called after a variable changes</li>
                            </ul>
                        </ul>
                    </li>
                </ul>
            </h4>
            <br />
            <h4>
                What is State?
                <ul>
                    <li>State is a variable that components can actively monitor.</li>
                    <li>If a state variable changes, the component will rerender to the DOM with the correct values</li>
                </ul>
            </h4>
        </>
    )
}

export default Hooks