import React from 'react';
import {Link} from 'react-router-dom';

export default function Header() {
  return (
   <header id="main-header">
        <div>
            <Link to="/">
          <h1>Home</h1>
            </Link>
            <Link to="/post">
            <h1>Post</h1>
            </Link>
        </div>
   </header>
  );
}