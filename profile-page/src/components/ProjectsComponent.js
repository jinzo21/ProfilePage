import React, { Component } from 'react';
import { Image, Thumbnail, Grid, Col, Row, Button, Overlay, Tooltip } from 'react-bootstrap';
import './ProjectsComponent.css';


class ProjectsComponent extends Component {
  render() {
    return (
      <div>
        <Grid fluid={true}>
          <Row>
          <Col xs={12} md={4}>
              <h3 className="text">POKEDEX</h3>
              <a href="https://github.com/jinzo21/PokedexWebApiReact">
                <Image src="mediaFiles/robot3.jpg" className="robot-image" responsive/>
              </a>
            </Col>
            <Col xs={12} md={4}>
              <h3 className="text">PROFILE</h3>
              <a href="https://github.com/jinzo21/ProfilePage">
                <Image src="mediaFiles/robot3.jpg" className="robot-image" responsive/>
              </a>
            </Col>
            <Col xs={12} md={4}>
              <h3 className="text">LAUSD SCRAPER</h3>
              <a href="https://github.com/jinzo21/CSharp-GradeBookApplication">
                <Image src="mediaFiles/robot3.jpg" className="robot-image" responsive/>
              </a>
            </Col>
          </Row>
          <br/>
          <br/>
          <br/>
          <Row>
          <Col xs={12} md={4}>
              <h3 className="text">MY COUNSELOR</h3>
              <a href="https://github.com/jinzo21/MyCounselor">
                <Image src="mediaFiles/robot3.jpg" className="robot-image" responsive/>
              </a>
            </Col>
            <Col xs={12} md={4}>
            <h3 className="text">IMBD SPARK</h3>
              <a href="https://github.com/">
                <Image src="mediaFiles/robot3.jpg" className="robot-image" responsive/>
              </a>
            </Col>
            <Col xs={12} md={4}>
              <h3 className="text">GITHUB</h3>
              <a href="https://github.com/">
                <Image src="mediaFiles/robot3.jpg" className="robot-image" responsive/>
              </a>
            </Col>
          </Row>
        </Grid>
      </div>
    )
  }
}

export default ProjectsComponent;