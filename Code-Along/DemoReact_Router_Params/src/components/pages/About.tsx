import { useNavigate } from "react-router";

const About = () => {
  const navigate = useNavigate();

  return (
    <div className="view">
      <h3>Information om oss på IT-Högskolan</h3>
      <p>
        Lorem ipsum dolor, sit amet consectetur adipisicing elit. Consequuntur
        asperiores quidem delectus laborum. Incidunt, itaque laboriosam? Qui
        quia ducimus temporibus asperiores deserunt facilis vitae at architecto,
        veritatis perferendis animi quos!
      </p>

      <button onClick={() => navigate("/")}>Tillbaka till startsidan</button>
    </div>
  );
};
export default About;
