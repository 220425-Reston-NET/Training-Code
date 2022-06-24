export interface Pokemon{
    name:string,
    health:number,
    pokeID:number,
    type:string,
    abilities:[
        {
            id:number,
            name:string,
            pp:number,
            power:number
        }
    ]
}