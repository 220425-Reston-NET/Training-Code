import React from 'react';
import './App.css';
import ComponentOne from './components/ComponentOne/ComponentOne';
import Events from './events/Events';
import ListComponent from './lists/ListComponent';
import Problem from './problem/Problem';
import ParentComponent from './props/ParentComponent/ParentComponent';

/* 
  What is react?
    - react is a frontend library to develop web UIs

  What is a SPA?
    - Single Page Application
    - instead of having mulitple html files, we only have one HTML and manipulate the dom to acheive the same goal

  What is JSX?
    - JavaScript XML
    - filetype that can write javascript and html code in the same file
  
  What is a component?
    - snippet of HTML, CSS and JavaScript
    - they are the building blocks of the HTML page
    - There are 2 types of components in react
      - functional components
      - class components
*/

//functional component
function App() : JSX.Element {
  return (
    <>
      <h2>Intro to Components</h2>
      <ComponentOne/>
      <h2>Events</h2>
      <Events/>
      <h2>Props</h2>
      <ParentComponent/>
      <h2>Lists</h2>
      <ListComponent/>
      <h2>Problem</h2>
      <Problem/>
    </>
  );
}

/* class App extends React.Component{
  render(): React.ReactNode {
      return(
        <>
          <h2>Hello React!</h2>
          <div>Element 2 </div>
        </>
      );
  }
} */

export default App;
