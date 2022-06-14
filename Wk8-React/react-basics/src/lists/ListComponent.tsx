import React from 'react'
import './ListComponent.css'

function ListComponent() {

    let names : string[] = ["Daniel", "Israel", "Chadel", "Troy"];

  return (
    <>
        {
            /* 
                - To display each item in an array to the DOM, we use the map array method.
                - The map function transforms each item in the array based on what you defined in the function.

                - The second argument in map is the index value of each item in the array, we can use the index value as the key property 
            */
            names.map((name, index) => {
                return (
                    <div key={index} className="name-div">{name}</div>
                )
            })
        }
    </>
  )
}

export default ListComponent;