import React, { useState } from "react";
import PokemonProfile  from "./PokemonProfile";
import { Pokemon } from "../model/pokemon";

function SelectPokemon() {

    let pokeDefault:Pokemon = {
        name:"Pikachu",
        health:0,
        pokeID:0,
        type:"",
        abilities:[
            {
                id:0,
                name:"",
                pp:0,
                power:0
            }
        ]
    };

    const [pokeObj, setPokeObj] = useState(pokeDefault);
    const [pokeName, setPokeName] = useState("");
    const [isFailed, setFailed] = useState(false);
    const [isHidden, setHidden] = useState(false);

    function updatePokeName(e: any) {
        setPokeName((prev) => e.target.value);
        // console.log(pokeName);
    }

    function onSubmit(e: React.FormEvent<HTMLFormElement>) {
        e.preventDefault();

        fetch("http://pokemonapireston-env.eba-3kaqziuz.us-east-1.elasticbeanstalk.com/api/Pokemon/SearchPokemonByName?" + new URLSearchParams({
            pokeName: pokeName
        }))
            .then(response => response.json())
            .then((pokemon:Pokemon) => {
                console.log(pokemon);

                //Changing the pokeObj variable to be what we got from the backend
                //Have to use useState to re-render the page
                setPokeObj((prev) => pokemon);
                setHidden((prev) => true);
                setFailed((prev) => false);
            }, () => {
                // console.log("It didn't find a pokemon")
                setFailed((prev) => true);
                setHidden((prev) => false);
            });
    }

    return (
        <div>
            <form onSubmit={onSubmit}>
                <div style={{marginLeft:'20rem', marginTop:'20rem', marginRight:'20rem'}}>
                <label>PokeName</label>
                <input type="text" className="form-control" onChange={updatePokeName}></input>
                {
                    isFailed && <span style={{color:'red'}}>Pokemon was not found!</span>
                }

                <button className="btn btn-primary">Submit</button>
                </div>
            </form>
            {
                isHidden &&
                <PokemonProfile {...pokeObj}></PokemonProfile>
            }
        </div>
    );
}

export default SelectPokemon;