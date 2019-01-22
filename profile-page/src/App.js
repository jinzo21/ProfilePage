import React, { Component } from 'react';
import { BrowserRouter, Route } from 'react-router-dom';
import HomeComponent from "./components/HomeComponent";
import AboutComponent from "./components/AboutComponent";
import ContactComponent from "./components/ContactComponent";
import NavigationComponent from "./components/NavigationComponent";
import ResumeComponent from "./components/ResumeComponent";
import ProjectsComponent from "./components/ProjectsComponent";
import FooterComponent from './components/FooterComponent';



class App extends Component {
  state = {
    landingPage: true
  }  

  render() {
      return (
        <BrowserRouter>
          <div>
            <NavigationComponent />
            <Route path="/" component={HomeComponent} exact />
            <Route path="/about" component={AboutComponent} />
            <Route path="/contact" component={ContactComponent} />
            <Route path="/resume" component={ResumeComponent} />
            <Route path="/projects" component={ProjectsComponent} />
            <FooterComponent/>
          </div>       
        </BrowserRouter>
      
    );
  }
}

export default App;
