import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect} from 'react-router-dom';

import './index.css';

import App from './pages/home/App';
import Catalogo from './pages/Catalogo/catalogo';
import NotFound from './pages/notFound/notFound';


import reportWebVitals from './reportWebVitals';

const rounting = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={App} />
        <Route path="/catalogo" component={Catalogo} />
        <Route exact path="/notfound" component={NotFound} />
        <Redirect to = "/notfound"/>
      </Switch>
    </div>
  </Router>
)

ReactDOM.render(rounting, document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
