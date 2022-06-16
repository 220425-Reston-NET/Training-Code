import React, { useEffect, useState } from 'react'
import { useSearchParams } from 'react-router-dom';
import { Pokemon } from '../../models/Pokemon';
import './PokeCard.css';

function PokeCard() {

    //need this to retrieve query param
    const [searchParams, setSearchParams] = useSearchParams();
    const [pokemon, setPokemon] = useState({} as Pokemon);
    const [isShiny, setShiny] = useState(false);


    useEffect(() => {
        let pokemonName = searchParams.get("pokemon")
        
        async function getOnePokemon(){
            let response = await fetch(`https://pokeapi.co/api/v2/pokemon/${pokemonName}`);
            let responseBody = await response.json();

            console.log(responseBody);

            setPokemon(responseBody);
        }

        getOnePokemon();

    }, []);

    function toggle(){
        setShiny(!isShiny);
    }

    return (
        pokemon.sprites ? 
        <div className='view-container'>
            <div className='card'>
                <div id="poke-name">{pokemon.name + ` ${pokemon.id}`}</div>
                <div id="img-container">
                    <img onClick={toggle} src={isShiny ? pokemon.sprites.front_shiny : pokemon.sprites.front_default} alt={pokemon.name} />
                </div>
                <div><b>Abilities</b></div>
                {
                    pokemon.types.map((item, index) => {
                        return (
                            <div key={index}>{item.type.name}</div>
                        )
                    })
                }
            </div>
        </div> : <></>
    )
}

export default PokeCard