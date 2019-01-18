import React, { Component } from 'react';
import { Image, Grid, Col, Row } from 'react-bootstrap';
import './HomeComponent.css';

class HomeComponent extends Component {
  render() {
    return (
      <div>
        <Grid>
          <Row>
            <Col xs={12} md={8}>
              <Image src="mediaFiles/dtla1.jpg" className="header-image" responsive/>           
            </Col>
          </Row>
        </Grid>
      </div>
    )
  }
}

export default HomeComponent;


