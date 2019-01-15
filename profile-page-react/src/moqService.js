import axios from 'axios';

export function pokedex_getAll(){
    return axios.get("pokedex/pokemon").then(resp => resp.data);
}

export async function todo_getAll(){
    const resp = await axios.get("pokedex/pokemon");
    return resp.data;
}