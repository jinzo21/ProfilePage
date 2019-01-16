import React from 'react';
import { Route, Switch } from 'react-router-dom';
import ContactPage from './contactPage';
import LandingPage from './landingPage';
import ProfilePage from './profilePage';
import ProjectsPage from './projectsPage';
import ResumePage from './resumePage';
import AboutMePage from './aboutMe';

const Main = () => (
    <Switch>
        <Route exact path="/" component={LandingPage} />
        <Route path="/aboutMe" component={AboutMePage} />
        <Route path="/contact" component={ContactPage} />
        <Route path="/projects" component={ProjectsPage} />
        <Route path="/profile" component={ProfilePage} />
        <Route path="/resume" component={ResumePage} />
    </Switch>
)
    
export default Main;