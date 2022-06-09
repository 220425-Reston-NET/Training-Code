function GetPokemon() {
    //Creating xhr object that has methods/properties to let us talk to a backend
    let xhr = new XMLHttpRequest();

    //Creating an empty object named pokemon
    let pokemon = {};

    let pokemonName = document.querySelector("#pokeName").value;

    //The moment you get an http response, go ahead and do this function that I set it to
    xhr.onreadystatechange = function() {
        /*
            0 - uninitialized
            1 - the connection to the backend was successful
            2 - loaded (request received by the backend and the backend is currenlty creating a response)
            3 - interactive (response was received by frontend but it is still currently being process)
            4 - complete
        */

        //Checks if the response was successful and was received by the backend
        if (this.readyState == 4 && (this.status > 199 && this.status < 300)) {
            
            //API that converts a JSON object into JS object for us to use
            pokemon = JSON.parse(xhr.responseText);

            //Dynamically change our website to show that information to the user
            document.querySelector("#imageResult").setAttribute("src", pokemon.sprites.front_default);
        }
        //Checks if the response was a 404 and changes the website to tell the user that it didn't work
        else if(this.status == 404) {
            document.querySelector("label").style.color = "red";
        }
    }

    //This sets our HTTP request, determines what http verb it is and where to send it
    xhr.open("GET", "https://pokeapi.co/api/v2/pokemon/" + pokemonName, true);

    //Sends the http request
    xhr.send();
}

function getPokemonFetch() {
    let pokemonName = document.querySelector("#pokeName").value;

    fetch("https://pokeapi.co/api/v2/pokemon/" + pokemonName)
        .then(result => result.json()) //Converting the response we get from the backend into JS object
        .then(pokemon => {
            //Dynamically change our website to show that information to the user
            document.querySelector("#imageResult").setAttribute("src", pokemon.sprites.front_default);
        });
}
