import React, { useEffect, useState } from 'react'
import { Link } from 'react-router-dom';
import './Dashboard.css'

function Dashboard() {

    const [pokemons, setPokemons] = useState([]);
    const [filteredPokemons, setFiltered] = useState([]);

    function handleInputChange(event : any){

        setFiltered(pokemons.filter((pokemon : any) => {
            return pokemon.name.includes(event.target.value)
        }));
    }

    useEffect(() => {

        //i need to send an asynchronous request
        async function getAllPokemon(){
            let response = await fetch("https://pokeapi.co/api/v2/pokemon?limit=151");
            let responseBody = await response.json();

            setPokemons(responseBody.results);
            setFiltered(responseBody.results);
        }

        getAllPokemon();
        
    }, [])


    return (
        <div className='dashboard-container'>

            <div className='input-container'>
                <input type="text" onChange={handleInputChange}/>
            </div>
        

            <div className='list-container'>
                {
                    filteredPokemons.map((pokemon : any, index) => {
                        return (
                            <Link className="poke-link" to={`/card?pokemon=${pokemon.name}`} key={index}>
                                <button>{pokemon.name}</button>
                            </Link>
                        );
                    })
                }
            </div>
        </div>
    )
}

export default Dashboard