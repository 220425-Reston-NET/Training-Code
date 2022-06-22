import React , {useEffect, useState} from "react";
import './App.css';

function App() {

  let pokeName = "";
  let pokeType = "";
  let pokeHealth = 0;

  const [pokemons, setPokemon] = useState([
    {
    pokeID: 0,
    name: "",
    type: ""
  }
])

  function updatePokeName(e: React.ChangeEvent<HTMLInputElement>) {

    pokeName = e.target.value;
    // console.log(pokeName);
  }

  function updatePokeType(e: React.ChangeEvent<HTMLInputElement>) {
    pokeType = e.target.value;

    // console.log(pokeType)
  }

  function updatePokeHealth(e: React.ChangeEvent<HTMLInputElement>){
    //+ sign will convert it to a number
    pokeHealth = +e.target.value;

    // console.log(pokeHealth)
  }

  function onSubmit(e: React.FormEvent<HTMLFormElement>) {
    //Will prevent the page from refreshing by itself once you submit
    //By default, a submit on a form will automatically refresh the page
    //Usually this is where you would re-direct the user to another page
    e.preventDefault();

    // console.log(`Name: ${pokeName} Type: ${pokeType} Health: ${pokeHealth}`);

    fetch('http://pokemonapireston-env.eba-3kaqziuz.us-east-1.elasticbeanstalk.com/api/Pokemon/AddPokemon', {
    method: 'POST',
    headers: {
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(
      {
      name: pokeName, 
      type: pokeType,
      health: pokeHealth
    })
    });

  }


  useEffect(() => {

    fetch("http://pokemonapireston-env.eba-3kaqziuz.us-east-1.elasticbeanstalk.com/api/Pokemon/GetAllPokemon")
      .then(response => response.json())
      .then(pokemons => {
        setPokemon((previousData) => pokemons)
      });

      //Means it will override the default configuration of useEffect to always execute whenever a value changes
  }, [])

  return (
    <div className="App">
      <ul>
        {pokemons.map(pokemon => <li>{pokemon.name}</li>)}
      </ul>
      <div>
        <form onSubmit={onSubmit}>
          <div>
            <label>Pokemon Name</label>
            <input type="text" name="pokeName" onChange={updatePokeName} ></input>
          </div>
          <div>
            <label>Pokemon Type</label>
            <input type="text" name="pokeType" onChange={updatePokeType}></input>
          </div>
          <div>
            <label>Pokemon Health</label>
            <input type="number" name="pokeHealth" onChange={updatePokeHealth}></input>
          </div>
          <button>Submit</button>
        </form>
      </div>
    </div>
  );
}

export default App;
