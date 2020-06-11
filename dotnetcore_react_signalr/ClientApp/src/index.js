import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, Switch, Route } from 'react-router-dom';
import App from './App';
import Admin from './Admin';
import registerServiceWorker from './registerServiceWorker';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

ReactDOM.render(
    <BrowserRouter basename={baseUrl}>
        <Switch>
            <Route exact path="/">
                <App />
            </Route>
            <Route exact path="/admin">
                <Admin />
            </Route>
        </Switch>
  </BrowserRouter>,
  rootElement);

registerServiceWorker();

