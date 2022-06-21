/*
    a slice is a collection of actions for a single global state in your app.
        - the name comes from splitting up the root redux state to multiple slices of state.
*/

import { createSlice } from "@reduxjs/toolkit";

export const counterSlice = createSlice({
    name: "counter",
    initialState: {value: 0},
    /* reducers define all of the actions for this slice */
    reducers: {
        increment(state){
            state.value++;
        }
    }
});

export const counterActions = counterSlice.actions;