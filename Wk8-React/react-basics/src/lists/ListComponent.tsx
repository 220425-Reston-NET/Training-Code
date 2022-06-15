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
    </>
  )
}

export default ListComponent;