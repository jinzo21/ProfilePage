import React, { Component }from 'react';
import { Image, Grid, Row, Col, Form, ControlLabel, FormControl, FormGroup, Button } from 'react-bootstrap';
import './ContactComponent.css';
import { GetPokemon, SendMail } from './MailServer.js';


class ContactComponent extends Component {
  componentWillMount(){
    GetPokemon();
    SendMail();
  }
  
  render() {
    return (
      <div>
        <Grid>
          <Row>
            <Col xs={12} sm={8} className="main-section">
              <Form horizontal>
                <FormGroup controlId="formHorizontalEmail">
                  <Col componentClass={ControlLabel} sm={2}>
                    EMAIL
                  </Col>
                  <Col sm={10}>
                    <FormControl type="email" placeholder="Email" />
                  </Col>
                </FormGroup>

                <FormGroup controlId="formControlsTextarea">
                  <Col componentClass={ControlLabel} sm={2}>
                    MESSAGE
                  </Col>
                  <Col sm={10}>
                    <FormControl type="textarea" placeholder="........." />
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