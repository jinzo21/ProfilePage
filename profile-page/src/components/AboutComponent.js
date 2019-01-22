import React, { Component } from 'react';
import { Grid, Row, Col, Image } from 'react-bootstrap';
import './AboutComponent.css';

class AboutComponent extends Component {
  render() {
    return (
      <div>
        <Grid fluid={true}>
          <Row>
            <Col Col xs={12} sm={12} md={12} lg={12}>
              <Image src="mediaFiles/apple2.jpg" className="head-image" responsive/>    
            </Col>      
            <br/>
          </Row>
          <Row>
          <br/>
            <Col Col xs={12} sm={12} md={12} lg={12}>
              <Image src="mediaFiles/bridge.jpg" className="page-devider" responsive/>    
            </Col>      
            <br/>
          </Row>
          <Row>
            <Col xs={12} sm={12} md={6} lg={6}>
              <br/>
              <Image src="mediaFiles/cover.jpg" className="half-pics" responsive/>    
            </Col>
            <Col xs={12} sm={12} md={6} lg={6} className="about-text">
              <h2>THEN</h2>
              <h4>Born & raised in Los Angeles, CA my journey into development started in high school as I developed MySpace portfolios for fellow friends & colleagues. Although I was limited to CSS/HTML, my introduction to development taught me that anything could be accomplished with the correct skill-set.</h4>
              <h4>Soon I programmed my TI-84 Calculator to enable gaming modules that included: pong, snake, & tik-tak-to. After graduating from USC in Southern California and serving as an AmeriCorps Member I decided to enter the workforce as a Developer.</h4>
            </Col>
          </Row>
          <br/>
          <Row>
            <Col xs={12} md={6} lg={6} className="about-text">
              <h2>NOW</h2>
              <h4>I am currently in Redmond, WA working with the Azure Optimization Automation team at Microsoft. Prior to this, I worked with a company creating custom .NET applications for clients within the real-estate market & before that I was building a Chinese caligraphy application with a start-up in Los Angeles, CA.</h4>
              <h4>I enjoy creating full-stack applications leveraging technologies such as React, Javascript, .NET Core 2.0, C#, and SQL Server 2016. My goal for the next 5 years is to continue to grow as a developer while making innovative & fun applications.</h4>
            </Col>
            <Col xs={12} sm={12} md={6} lg={6}>
              <br/>
              <Image src="mediaFiles/setup.jpg" className="half-pics" responsive/>    
            </Col>
            <Col xs={12} md={6} lg={6}>
            </Col>
          </Row>
      </Grid>
    </div>
    )
  }
}

export default AboutComponent;