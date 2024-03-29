import React from 'react'
import { useSelector } from 'react-redux'
import { Link } from 'react-router-dom'

function Nav() {

    //this is how you access the global counter value
    const counter = useSelector((state : any) => state.counter.value);

  return (
    <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
        <div className="container-fluid">
            <a className="navbar-brand" href="#">Navbar</a>
            <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span className="navbar-toggler-icon"></span>
            </button>
            <div className="collapse navbar-collapse" id="navbarNav">
            <ul className="navbar-nav">
                <li className="nav-item">
                    <Link to="/" className="nav-link">Components</Link>
                </li>
                <li className="nav-item">
                    <Link to="/events" className="nav-link">Events</Link>
                </li>
                <li className="nav-item">
                    <Link to="/props" className="nav-link">Props</Link>
                </li>
                <li className="nav-item">
                    <Link to="/hooks" className="nav-link">Hooks</Link>
                </li>
                <li className="nav-item">
                    <Link to="/lists" className="nav-link">Lists</Link>
                </li>
                <li className="nav-item">
                    <Link to="/hooks" className='nav-link'>{counter}</Link>
                </li>
            </ul>
            </div>
        </div>
    </nav>
  )
}

export default Nav