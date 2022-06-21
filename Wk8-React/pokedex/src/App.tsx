import React from 'react';
import logo from './logo.svg';
import './App.css';
import { Route, Routes } from 'react-router-dom';
import Dashboard from './routes/dashboard/Dashboard';
import PokeCard from './routes/pokecard/PokeCard';
import Nav from './shared/Nav';

function App() {
  return (
    <>
      <Nav/>
      <Routes>
        <Route path='/' element={<Dashboard/>}/>
        <Route path='/card' element={<PokeCard/>}/>
      </Routes>
    </>
  );
}

export default App;
