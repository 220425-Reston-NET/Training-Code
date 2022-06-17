import { render, screen } from '@testing-library/react';
import react from 'react'
import { MemoryRouter } from 'react-router-dom';
import ComponentOne from '../components/ComponentOne/ComponentOne';


/* 
What is Jest?
    - Jest is a javascript testing framework utilized with react.
    - We can check if tests pass or fail with jest


What is React Testing Library?
    - it is a dependency that allows us to test the DOM tree rendered to the browser
    - this allows us to write tests that resemble how a user would use the application

    Keywords for RTL:
        - render : allows us to render a component to test
        - screen : allows us to query elements from the rendered component
            - methods for querying from the component
                - getByText() : goes through the component tree and looks for elements that specific text
                - getByTestId() : we can add an attribute to an element to retrieve it that way
                    - data-testid=""
                - getByRole() 
                    - can retrieve the role attribute in the html element
                    - if there isnt one, you can access it by the tag name
                - getPlaceholderText() : by input placeholder values
*/


test("check 3 ComponentTwos are displayed to the screen", () => {

    //we need to render a component
    render(<MemoryRouter><ComponentOne/></MemoryRouter>)

    let componentTwos : HTMLElement[] = screen.getAllByText("ComponentTwo");

    expect(componentTwos).toHaveLength(3);
});