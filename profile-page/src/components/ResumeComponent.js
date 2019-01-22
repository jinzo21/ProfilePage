import React, { Component } from 'react';
import { Image, Row, Grid, Col, Tab, Tabs } from 'react-bootstrap';
import './ResumeComponent.css';

class ResumeComponent extends Component {
  render() {
    return (
        <div>
          <Grid fluid={true}>
            <Row>
              <Col xs={12} md={12}>
                <Image src="mediaFiles/danboard.jpg" className="cat-image" responsive/>           
              </Col>
            </Row>
            <Row>
              <br />
              <Col xs={12} s={12} md={12}>
              <Image src="mediaFiles/cat2.jpg" className="resume-devider"/>    
              <br />   
              <br />   
              </Col>
            </Row>
            <Row>
              <Col xs={12} s={12} md={4} className="icons">
                <Row>
                <i className="devicon-javascript-plain"></i>
                <i class="devicon-html5-plain"></i>
                <i class="devicon-css3-plain"></i>
                <i class="devicon-bootstrap-plain"></i>
                </Row>
                <Row>
                <i class="devicon-react-original"></i>
                <i class="devicon-csharp-plain"></i>
                <i class="devicon-windows8-original"></i>
                <i class="devicon-visualstudio-plain"></i>
                </Row>
                <Row>
                <i class="devicon-github-plain"></i>
                <i class="devicon-git-plain"></i>
                <i class="devicon-chrome-plain"></i>
                <i class="devicon-firefox-plain"></i>
                </Row>
              </Col>
              <Col xs={12} s={12} md={8} >
                <Tabs defaultActiveKey={1} animation={false} id="noanim-tab-example">
                  <Tab eventKey={1} title="MICROSOFT" className="tab-header">
                    <br/>
                    <h4 >I currently work with the Azure Optimization Automation team at Microsoft HQ in Redmond, WA. Our team primarly works on creating recommendations for various Azure services. I am working on optimizing our VM/DataDisk recommendation by leveraging tools with Azure such as Graph, Resource Graph, Data Warehouse, DataBricks, & Kusto.</h4>
                  </Tab>
                  <Tab eventKey={2} title="ALTUS">
                    <h4>I worked with the Altus Group in Irvine, CA as a software engineering building custom real-estate .NET applications. My responsibilities included creating/updating existing applications & gathering user feedback. One of my projects dealt with a client in China and another in South Africa! We primarily worked within the .NET suite: C#, SQL Server 2016, XML, Excel, & WPF.</h4>
                  </Tab>
                  <Tab eventKey={3} title="BABBLE DABBLE">
                    <h4>While at Babble Dabble in Culver City, CA I worked on creating a real-time competitive Chinese calligraphy platform. The server was built using ASP.NET Web API 2 (.NET 4.6) while our client-side interface used React (just like this website). There I worked on our user registration flow, integrated 3rd party APIs including Stipe & Sendgrid, & worked with SQL Server Code in designing table schemas & stored procedures.</h4>
                  </Tab>
                </Tabs>         
              </Col>
            </Row>
          </Grid>
        </div>
      )
  }
}

export default ResumeComponent;


