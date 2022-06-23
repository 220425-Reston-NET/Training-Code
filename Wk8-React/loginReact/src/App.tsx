import React from 'react';
import logo from './logo.svg';
import './App.css';
import LoginButton from './component/login';
import LogoutButton from './component/logout';
import Profile from './component/profile';
import { useAuth0 } from '@auth0/auth0-react';

function App() {
  const {isAuthenticated} = useAuth0();


  return (
    <div className="App">
      {
        isAuthenticated ? 
        <div>
          <LogoutButton></LogoutButton>
          <Profile></Profile>
        </div>
        :
        <LoginButton></LoginButton>
      }
    </div>
  );
}

export default App;
