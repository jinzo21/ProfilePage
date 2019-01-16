import React, { Component } from 'react';
import './App.css';
import Main from './Components/main';
import { Link } from 'react-router-dom';
import { Content, Drawer, Layout, Header, Navigation } from 'react-mdl';


class App extends Component {
  render() {
    return (
      <div>
        <Layout>
          <Header title="Title" scroll>
              <Navigation>
                  <Link to="/aboutMe">About Me</Link>
                  <Link to="/resume">Resume</Link>
                  <Link to="/projects">Projects</Link>
                  <Link to="/contact">Contact</Link>
              </Navigation>
          </Header>
          <Drawer title="Title">
              <Navigation>
                  <Link to="/aboutMe">About Me</Link>
                  <Link to="/resume">Resume</Link>
                  <Link to="/projects">Projects</Link>
                  <Link to="/contact">Contact</Link>
              </Navigation>
          </Drawer>
          <Content>
              <div className="page-content" />
          </Content>
          <Main />
        </Layout>
      </div>
    );
  }
}

export default App;
