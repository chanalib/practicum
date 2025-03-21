import { useNavigate } from 'react-router-dom';

const Home = () => {
    const navigate = useNavigate();

    return (
        <div>
            <h1>Welcome to the Home Page</h1>
            <button onClick={() => navigate('/register')}>Go to Register</button> {/* כפתור ניווט */}
        </div>
    );
};

export default Home;
