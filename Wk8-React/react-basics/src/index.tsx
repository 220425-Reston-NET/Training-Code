import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter } from 'react-router-dom';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
//shift + alt + a     is to create a block comment in vs code
/* 
  What is React Router?
    its a dependency that allows us to mimic having different "pages" in our single page application

  Steps to setup React Router
    1: wrap the <App/> component in a tag called <BrowserRouter> in the index.tsx
    2: We are going to define our routes in the App.tsx component


*/

root.render(
  <React.StrictMode>
    <BrowserRouter>
      <App />
    </BrowserRouter>
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
