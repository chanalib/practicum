// src/App.tsx
import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Home from './components/Home';
import Register from './components/Register';
import Login from './components/Login';


const App = () => {
    return (
        <Router>
            <Routes>
                <Route path="" element={<Home />} />
                <Route path="/register" element={<Register />} />
                <Route path="/login" element={<Login />} /> {/* הוספת Route עבור ההתחברות */}
            </Routes>
        </Router>
    );
};

export default App;
