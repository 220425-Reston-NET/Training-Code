import React from 'react'
import './ListComponent.css'

function ListComponent() {

    let names : string[] = ["Daniel", "Israel", "Chadel", "Troy"];

  return (
    <>
        {
            /* 
                - To display each item in an array to the DOM, we use the map array method.
                - The map function transforms each item in the array.
            */
            names.map((name, index) => {
                return (
                    <div key={index} className="name-div">{name}</div>
                )
            })

        }

        <h4>
            What does the map() function do in javascript?
          <ul>
            <li>Allows us to transform values in one array into another array with the desired format we want</li>
            <li>We utilize it in React to convert an array of items into an array of JSX Elements to be displayed to the screen</li>
          </ul>
        </h4>  
    </>
  )
}

export default ListComponent;