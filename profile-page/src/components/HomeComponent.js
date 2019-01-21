import React, { Component } from 'react';
import { Image, Grid, Col, Row } from 'react-bootstrap';
import './HomeComponent.css';

class HomeComponent extends Component {
  render() {
    return (
      <Grid fluid={true}>
        <Row>
          <Col Col xs={12} sm={12} md={12} lg={12}>
              <div className="section" style={{ textAlign: "center" }}>
                <div className="color-overlay" ></div>
                <div className="video-container" >
                  <video src="mediaFiles/JAPANPromo.mov" autoplay="true" muted="true" loop="true" ></video>
                </div>
                <div className="home-text">
                  <h1>IMAGINE. CREATE. BUILD.</h1>
                  {/* <div className="button-overlay">WELCOME</div> */}
                </div>
              </div>
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
            <h3>I am here to create that which is imagined. But in order to put the pieces of the puzzle together, I must first understand the puzzle itself. You are my guide. You are the storyteller. I am simply a master mason who will bring your vision to life.</h3>
          </Col>
        </Row>
      </Grid>

    )
  }
}

export default HomeComponent;


