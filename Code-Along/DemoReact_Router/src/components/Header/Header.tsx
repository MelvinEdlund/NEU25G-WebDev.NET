import "./Header.css";
import { Link } from "react-router";

// Detta motsvarar navigeringsmenyn som brukar finnas överst på sida i de flesta webblösningar
// Här finns tre navigeringsalternativ: Startsidan, om företaget och kontakt

const Header = () => {
  return (
    <header className="header">
      <nav className="navbar">
        <Link to="/">Home</Link>
        <Link to="/about">About</Link>
        <Link to="/contact">Contact</Link>
        <Link to="/products">Products</Link>
      </nav>
    </header>
  );
};

export default Header;
