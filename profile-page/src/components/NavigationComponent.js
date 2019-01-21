import React from "react";
import { Navbar, Nav, NavItem } from 'react-bootstrap';
import { Link } from 'react-router-dom';
import './NavigationComponent.css';

const NavigationComponent = () => {
  return (
    <Navbar staticTop>
      <Navbar.Header>
        <Navbar.Toggle />
      </Navbar.Header>
      <Navbar.Collapse>
        <Nav pullRight>
         <NavItem eventKey={1} componentClass={Link} href="/" to="/">
            HOME
          </NavItem>
          <NavItem eventKey={2} componentClass={Link} href="/" to="/about">
            ABOUT
          </NavItem>
          <NavItem eventKey={3} componentClass={Link} href="/resume" to="/resume">
            RESUME
          </NavItem>
          <NavItem eventKey={4} componentClass={Link} href="/projects" to="/projects">
            PROJECTS
          </NavItem>
          <NavItem eventKey={5} componentClass={Link} href="/contact" to="/contact">
            CONTACT
          </NavItem>
        </Nav>
      </Navbar.Collapse>
    </Navbar>
  );
};

export default NavigationComponent;