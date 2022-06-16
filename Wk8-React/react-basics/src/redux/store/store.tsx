/* 
    What is redux?
        - Redux is a dependency that can manage global state
        - since react is unidirectional, have a global location for state that all components can accessible is beneficial  

    What is a design pattern?
        - A solution to a common computer science 
    
    Redux utilizes a design pattern called the Flux Design Pattern
        - How it works:
            - There is a central store somewhere that holds the global application state
            - Views can dispatch an action to the store to manipulate the state.
            - Views can utilize the global state values just like a state variable in the component

        action -> dispatched -> store -> views
        ^                                   |
        |                                   |
        |-----------------------------------<

    What is a store?
        - a store is a state that is globally stored so multiple components can access it
    
    What is a view?
        - a view actively monitors when a store changes so the view can be updated with the correct info
        - in our situation, the view is our component

    What is an action?
        - a method defined to manipulate the store
    
    What is a dispatcher?
        - delivers the action to the store
*/

import { configureStore } from "@reduxjs/toolkit";
import { counterSlice } from "../slices/counterSlice";

const store = configureStore({
    reducer: {
        counter: counterSlice.reducer
    }
})

export default store;