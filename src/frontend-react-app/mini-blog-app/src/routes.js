import React from 'react';
import {Switch , Route} from 'react-router-dom';


import  home from './Pages/home';
import  post from './Pages/post';

function Routes(){
    return(
        <Switch>
        <Route path="/" exact component={home} /> 
        <Route path="/post" component={post} />      
        </Switch>
    );

}

export  default Routes;