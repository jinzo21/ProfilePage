import React, { Component } from 'react';
import './App.css';
import { pokedex_getAll } from "./moqService";

class App extends Component {
  state = {
    pokemon: []
  }

  async componentDidMount(){
    const pokemon = await pokedex_getAll();
    console.log(pokemon);
    this.setState({pokemon}); 
  }
  
  render() {
    const { pokemon } = this.state;

    return (
      <div>
        { pokemon.map( pokemon => (
          <div>{ pokemon.PokemonName }</div>
          ))}
      </div>
    );
  }
}

export default App;
