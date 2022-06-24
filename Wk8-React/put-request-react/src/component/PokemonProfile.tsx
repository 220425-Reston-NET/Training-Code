import React, { useState } from 'react'
import { Pokemon } from "../model/pokemon";


function PokemonProfile(props: Pokemon) {

    const [abilityArray, setAbilityArray] = useState(props.abilities);
    const [abilityName, setAbilityName] = useState("");
    const [ppNumberInput, setPP] = useState(0);
    const [isHidden, setHidden] = useState(false);

    function handleChange(e:any) {
        setAbilityName((prev) => e.target.value);

        // console.log(abilityName);
    }

    function updatePP(e: any) {
        setPP(e.target.value);
        
        if (ppNumberInput < 0) {
            setHidden(true);
        }
        else{
            setHidden(false);
        }
    }

    function onSubmit(e: any) {

        //Logic to find the ability Id by using the ability name
        let abId = 0;
        props.abilities.map((ability) => {
            if (abilityName == ability.name) {
                abId = ability.id;
            }
        });

        fetch('http://pokemonapireston-env.eba-3kaqziuz.us-east-1.elasticbeanstalk.com/api/Pokemon/ReplenishPP?' + new URLSearchParams({
            p_PP:ppNumberInput+"",
            p_abId:abId+"",
            p_pokeId:props.pokeID+""
        }), {
            method: 'PUT',
        })
            .then(response => response.ok)
            .then(data => {
                // setAbilityArray((prev) => {
                //     prev.map((ability) => {
                //         if (ability.name == abilityName) {
                //             ability.pp = ppNumberInput;
                //         }
                //     })
                //     return prev;
                // })
            });
    }

  return (
    <div>
        <h1>Pokemon Profile</h1>
        <h5>{props.name}</h5>
        <h5>{props.health}</h5>
        <h5>{props.type}</h5>

        <select value={abilityName} onChange={handleChange}>
            {
                abilityArray.length > 0?
                    abilityArray.map((ability) => <option value={ability.name}>{ability.name}:{ability.pp}</option>)
                :
                <option>Currently no abilities in this pokemon</option>
            }
        </select>
        <br/>

            <div style={{marginLeft:'20rem', marginRight:'20rem'}}>
                <label>PP</label>
                <input type='number' min='0' className="form-control" onChange={updatePP}></input>
                {isHidden && <span style={{color:'red'}}>Cannot input negative!</span> }
                <button className="btn btn-primary" onClick={onSubmit} disabled={isHidden}>Update PP</button>
            </div>
    </div>
  )
}

export default PokemonProfile;