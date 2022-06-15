import React from 'react'

function Problem() {

    let isVisible = true;

    function toggleDiv(){
        console.log(isVisible);
        isVisible = !isVisible;
    }

    /*  as of tuesday, the dom doesnt change based on variable values since it already has been rendered.
            Tomorrow we will learn how to resolve this issue.
    */
  return (
    <>
        {
            //ternary operation
            // if isVisible is true, the h2 element will be displayed. else, the empty tag will be displayed
            isVisible ? <h2 id="h2-div">Hello World</h2> : <></>
        }
        <button onClick={toggleDiv}>toggle</button>
    </>
    
  )
}

export default Problem