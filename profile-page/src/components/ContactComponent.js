import React, { Component }from 'react';
import { Image, Grid, Row, Col, Form, ControlLabel, FormControl, FormGroup, Button, ListGroup, ListGroupItem } from 'react-bootstrap';
import './ContactComponent.css';
import { GetPokemon, SendMail } from './MailServer.js';


class ContactComponent extends Component {
  
  state = {
    name: "",
    email: "",
    phone: "",
    message: ""
  };
  
  render() {
    return (
      <div>
        <Grid fluid={true}>
          <Row>
            <Col xs={12} sm={12} md={12} lg={12}responsive>
                <Image src="mediaFiles/brdige2.jpg" className="contact-image" />              
            </Col>
          </Row>
          <Row>
            <br />
            <Col xs={12} sm={6}>
              <Form horizontal>
                <FormGroup controlId="formHorizontalEmail">
                  <Col componentClass={ControlLabel} sm={2}>
                    NAME
                  </Col>
                  <Col sm={10}>
                    <FormControl 
                      type="textarea" 
                      onChange={e => this.setState({ name: e.target.value })} />
                  </Col>
                </FormGroup>
                <FormGroup controlId="formHorizontalEmail">
                  <Col componentClass={ControlLabel} sm={2}>
                    EMAIL
                  </Col>
                  <Col sm={10}>
                    <FormControl 
                      type="email" 
                      onChange={e => this.setState({ email: e.target.value })} />
                  </Col>
                </FormGroup>
                <FormGroup controlId="formHorizontalEmail">
                  <Col componentClass={ControlLabel} sm={2}>
                    PHONE
                  </Col>
                  <Col sm={10}>
                    <FormControl 
                      type="textarea" 
                      onChange={e => this.setState({ phone: e.target.value })} />
                  </Col>
                </FormGroup>
                <FormGroup controlId="formControlsTextarea">
                  <Col componentClass={ControlLabel} sm={2}>
                    MESSAGE
                  </Col>
                  <Col sm={10}>
                    <FormControl 
                      type="textarea" 
                      style={{ height: 150 }}
                      onChange={e => this.setState({ message: e.target.value })} />
                  </Col>
                </FormGroup>

                <FormGroup>
                  <Col smOffset={2} sm={10}>
                    <Button type="submit">SEND</Button>
                  </Col>
                </FormGroup>
              </Form>
            </Col>
            <Col xs={12} sm={6}>
            <ListGroup>
              <ListGroupItem>
                <h3>CONTACT INFORMATION</h3>
                <h4>albertojurbina@gmail.com</h4> 
              </ListGroupItem>
              <br/>
              <ListGroupItem>
                <h3>CURRENT POSITION</h3>
                <h4>Software Design Engineer</h4>
                <h4>Azure Optimization Automation</h4>
                <h4>Redmond, WA - Microsoft</h4>
              </ListGroupItem>
            </ListGroup>
            </Col>
          </Row>
        </Grid>
      </div>
    )
  }
}

export default ContactComponent;