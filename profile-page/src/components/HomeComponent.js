import React, { Component } from 'react';
import { Image, Grid, Col, Row, Thumbnail } from 'react-bootstrap';
import './HomeComponent.css';
import { Link } from 'react-router-dom';


class HomeComponent extends Component {
  render() {
    return (
      <Grid fluid={true}>
        <Row>
          
          <Col Col xs={12} sm={12} md={12} lg={12}>
          
            <video src="mediaFiles/geckoAnimation.mp4" autoplay="true" muted="true" loop="true" responsive></video>
          
          </Col>
        </Row>
        <Row >
          <Col xs={12} s={12} md={12}>
            <Image src="mediaFiles/cat2.jpg" className="resume-devider"/>    
            <br />   
            <br />   
           </Col>
        </Row>
        <Row >
          <Col xs={12} s={12} md={12}>  
            <div className="quote">
              <h4>"WHERE THE SPIRIT DOES NOT WORK WITH THE HAND, THERE IS NOT ART"</h4>
            </div>  
          </Col>
        </Row>
        <br/>
        <Row>
    <Col xs={12} md={4}>
      <Thumbnail src="mediaFiles/astronaut2.jpg" alt="242x200">
        <Link to="about" style={{ textDecoration: 'none' }}  className="card-text"><h3>VISIONARY</h3></Link>
      </Thumbnail>
    </Col>
    <Col xs={12} md={4}>
      <Thumbnail src="mediaFiles/cube.jpg" alt="242x200">
        <Link to="projects" style={{ textDecoration: 'none' }}  className="card-text"><h3>CREATOR</h3></Link>
      </Thumbnail>
    </Col>
    <Col xs={12} md={4}>
      <Thumbnail src="mediaFiles/bridge.jpg" alt="242x200">
        <Link to="contact" style={{ textDecoration: 'none' }}  className="card-text"><h3>MESSENGER</h3></Link>
      </Thumbnail>
    </Col>
  </Row>
      </Grid>

    )
  }
}

export default HomeComponent;


