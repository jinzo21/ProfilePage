import axios from 'axios';

/*
export function to_getAll(){
    // from the response we just take the data (resp contains other things)
    return axios.get('/api/todos').then(resp => resp.data);
}

// here we use an async js funtion: it essentialy builds the .then response for you 
export async function todo_getall_async(){
    const resp = await axios.get('/api/todos');
    return resp.data;
}
*/

export function SendMail(){
    axios.post('/profile/sendMail', {
        "Name": 'Fred',
        "Email": 'Flintstone',
        "Message": "adsadsa"
      })
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      })
}

export function GetPokemon() {
    return axios.get('/pokedex/pokemon');
}

