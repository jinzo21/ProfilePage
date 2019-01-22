import React, { Component } from 'react';
import { Carousel } from 'react-bootstrap';
import './ProjectsComponent.css';
import { Link } from 'react-router-dom';


class ProjectsComponent extends Component {
  render() {
    return (
      <div>
           <Carousel>
            <Carousel.Item className="carousel-img" >
              <img src="mediaFiles/wire.jpg" />
              <Carousel.Caption>
                <a href="https://github.com/jinzo21"><h3>GitHub</h3></a>
                <h4>Profile page holding code samples.</h4>
              </Carousel.Caption>
            </Carousel.Item>
            <Carousel.Item className="carousel-img">
              <img src="mediaFiles/pokemon.jpg" />
              <Carousel.Caption>
                <a href="https://github.com/jinzo21/PokedexWebApiReact"><h3>POKEDEX</h3></a>
                <h4>React based Pokedex: holds information on the first 150 Pokemon.</h4>
              </Carousel.Caption>
            </Carousel.Item>
            <Carousel.Item className="carousel-img">
              <img src="mediaFiles/books.jpg" />
              <Carousel.Caption>
                <a href="https://github.com/jinzo21/MyCounselor"><h3>LAUSD SCRAPER</h3></a>
                <h4>Scraped the Los Angeles School Unified District's class schedule.</h4>
              </Carousel.Caption>
            </Carousel.Item>
          </Carousel>
      </div>
    )
  }
}

export default ProjectsComponent;