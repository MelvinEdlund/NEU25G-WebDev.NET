import { useParams } from "react-router";
import { useNavigate } from "react-router";

export default function ProductDetails() {
  const navigate = useNavigate();

  const { id } = useParams();

  return (
    <div>
      <h2>Produktens id är: {id}</h2>
      <button type="button" onClick={() => navigate("/products")}>
        Tillbaka till produkter
      </button>
    </div>
  );
}
