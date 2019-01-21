import React, { Component }from 'react';
import { Image, Grid, Row, Col, Form, ControlLabel, FormControl, FormGroup, Button } from 'react-bootstrap';
import './ContactComponent.css';
import { GetPokemon, SendMail } from './MailServer.js';


class ContactComponent extends Component {
  
  state = {
    name: "",
    email: "",
    message: ""
  };
  
  render() {

    console.log(this.state.name);

    return (
      <div>
        <Grid fluid={true}>
          <Row>
            <br />
            <Col xs={12} sm={8} className="main-section">
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
            <Col xs={12} sm={4} className="sidebar-section">
              <Image src="mediaFiles/astronaut1.jpg" responsive/>
              <h5>Thank you for reaching out. I'll be sure to respond within a day.</h5>
            </Col>
          </Row>
        </Grid>
      </div>
    )
  }
}

export default ContactComponent;