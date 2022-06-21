import { fireEvent, render, screen } from '@testing-library/react';
import react from 'react';
import { Provider } from 'react-redux';
import { MemoryRouter } from 'react-router-dom';
import Hooks from '../hooks/Hooks';
import store from '../redux/store/store';


test("increment button increases number", () => {
    //MemoryRouter is needed if you are utilizing react router
    //Provider is needed if the component utilizes redux
    render(<MemoryRouter><Provider store={store}><Hooks/></Provider></MemoryRouter>);

    let incrementBtn = screen.getByTestId("increment-btn");
    let counterDiv = screen.getByTestId("counter-div");

    expect(counterDiv).toHaveTextContent("0");

    //We use fireEvent to trigger a specific event to happen on an element
    fireEvent.click(incrementBtn);

    expect(counterDiv).toHaveTextContent("1");

})


test("check if onchange event is working for the input", () => {
    render(<MemoryRouter><Provider store={store}><Hooks/></Provider></MemoryRouter>);

    let inputElem = screen.getByTestId("text-input");
    let h2Elem = screen.getByTestId("text-h2");

    expect(h2Elem).toHaveTextContent("");

    fireEvent.change(inputElem, {target: {value: "kevin"}});

    expect(h2Elem).toHaveTextContent("kevin");

});