import { Link } from "react-router";
const Contact = () => {
  return (
    <div className="view">
      <h3>Kontakta oss på IT-Högskolan</h3>
      <p>
        Lorem ipsum dolor, sit amet consectetur adipisicing elit. Consequuntur
        asperiores quidem delectus laborum. Incidunt, itaque laboriosam? Qui
        quia ducimus temporibus asperiores deserunt facilis vitae at architecto,
        veritatis perferendis animi quos!
      </p>
      <ul>
        <li>
          <Link to="/">Startsida</Link>
        </li>
        <li>
          <Link to="/About">About</Link>
        </li>
      </ul>
    </div>
  );
};
export default Contact;
