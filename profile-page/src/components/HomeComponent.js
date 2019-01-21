import React, { Component } from 'react';
import { Button, Grid, Col, Row } from 'react-bootstrap';
import './HomeComponent.css';

class HomeComponent extends Component {
  render() {
    return (
      <Grid fluid={true}>
        <Row responsive>
          <Col Col xs={12} sm={12} md={12} lg={12} responsive>
              <div className="section" responsive style={{ textAlign: "center" }}>
                <div className="color-overlay" responsive></div>
                <div className="video-container" responsive>
                  <video src="mediaFiles/JAPANPromo.mov" autoplay="true" muted="true" loop="true" responsive></video>
                </div>
                <div>
                <h1>IMAGINE. CREATE. BUILD.</h1>
                <div className="button-overlay">WELCOME</div>
                </div>
                
              </div>
          </Col>
        </Row>
        <Row responsive>
          <Col Col xs={12} sm={12} md={12} lg={12} responsive>
          </Col>
        </Row>
      </Grid>

    )
  }
}

export default HomeComponent;


