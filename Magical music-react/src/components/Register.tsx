// src/Register.js
import axios from 'axios';
import { useState } from 'react';
import { useNavigate } from 'react-router-dom';

const Register = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const navigate = useNavigate(); // הוספת useNavigate

    const handleRegister = async (e:any) => {
        e.preventDefault();
        try {
            const response = await axios.post('http://localhost:5000/api/register', {
                username,
                password,
            });
            console.log('User registered:', response.data);
            // לאחר הרשמה מוצלחת, נווט לדף אחר (למשל לדף הבית)
            navigate('/'); // שנה את הנתיב לפי הצורך
        } catch (error) {
            console.error('There was an error registering!', error);
        }
    };

    return (
        <div>
            <form onSubmit={handleRegister}>
                <input
                    type="text"
                    placeholder="Username"
                    value={username}
                    onChange={(e) => setUsername(e.target.value)}
                    required
                />
                <input
                    type="password"
                    placeholder="Password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                    required
                />
                <button type="submit">Register</button>
            </form>
            <button onClick={() => navigate('/login')}>Go to Login</button> {/* כפתור ניווט */}
        </div>
    );
};

export default Register;
