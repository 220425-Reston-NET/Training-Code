export interface Pokemon{
    name : string;
    id: number;
    sprites: {
        front_default : string,
        front_shiny: string
    };
    types: {
        type: {
            name: string
        }
    }[]
}