﻿import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';

import Header from './components/headerComponent/header';
import MainPage from './components/pages/mainPage/mainPage';
import RestaurantList from './components/pages/restaurants/RestaurantList';
import LoginForm from './components/pages/auth/login';

class App extends Component {
    render() {
        return (
            <Router>
                <div className="App">
                    <Header />
                    <Route exact path="/" component={MainPage} />
                    <Route exact path="/restaurants" component={RestaurantList} />
                    <Route exact path="/login" component={LoginForm} />

                </div>
            </Router>
        );
    }
}

export default App;