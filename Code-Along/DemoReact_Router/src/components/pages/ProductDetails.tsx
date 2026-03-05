import { useParams } from "react-router";

export default function ProductDetails() {
  const { id } = useParams();

  return <h2>Produktens id är: {id}</h2>;
}
