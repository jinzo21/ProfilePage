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
              <h1>Landing Page</h1>       
            </Col>
          </Row>
        </Grid>
      </div>
    )
  }
}

export default HomeComponent;


