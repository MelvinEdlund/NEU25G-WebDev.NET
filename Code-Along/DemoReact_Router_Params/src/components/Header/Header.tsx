import "./Header.css";
import { Link } from "react-router";
import { NavLink } from "react-router";

// Detta motsvarar navigeringsmenyn som brukar finnas överst på sida i de flesta webblösningar
// Här finns tre navigeringsalternativ: Startsidan, om företaget och kontakt

const Header = () => {
  return (
    <nav className="navbar">
      <header className="header">
        <ul>
          <li>
            <NavLink to="/">Home</NavLink>
          </li>
          <li>
            <NavLink to="/about">About</NavLink>
          </li>
          <li>
            <NavLink to="/contact">Contact</NavLink>
          </li>
          <li>
            <NavLink to="/products">Products</NavLink>
          </li>
          <ul>
            <a>Våra Utbildningar</a>
            <li>
              <NavLink to="/educations/1">.NET Cloud</NavLink>
            </li>
            <li>
              <NavLink to="/educations/2">.NET Utvecklare</NavLink>
            </li>{" "}
            <li>
              <NavLink to="/educations/3">Frontend Utvecklare</NavLink>
            </li>
          </ul>
        </ul>
      </header>
    </nav>
  );
};

export default Header;
