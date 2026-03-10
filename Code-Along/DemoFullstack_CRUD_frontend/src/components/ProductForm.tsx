import type { Product } from "../types/Product";
import { useState } from "react";
import {
  getAllProducts,
  addProduct,
  updateProduct,
  deleteProduct,
} from "../services/ProductService";

const ProductForm = () => {
  //Meddelande som kommer styrs av vad webapi:et skickar tillbaka
  const [message, setMessage] = useState<string>("");

  const handleSave = () => {
    const product: Product = {
      productid: 0,
      productname: "Iphone 15",
      price: 6999,
    };
    addProduct(product).then((ret) => {
      const text = ret ? "Produkten sparades" : "Någonting gick fel";
      setMessage(text);
    });
  };

  const handleUpdate = () => {
    const product: Product = {
      productid: 9,
      productname: "Iphone 15 uppdaterad",
      price: 3999,
    };
    updateProduct(product).then((ret) => {
      const text = ret ? "Produkten uppdaterades" : "Någonting gick fel";
      setMessage(text);
    });
  };

  const handleDelete = () => {
    const product: Product = {
      productid: 9,
      productname: "Iphone 15",
      price: 3999,
    };
    deleteProduct(product).then((ret) => {
      const text = ret ? "Produkten togs bort" : "Någonting gick fel";
      setMessage(text);
    });
  };

  const handleSelect = () => {
    getAllProducts().then((products) => {
      alert(JSON.stringify(products));
    });
  };

  return (
    <>
      <button onClick={handleSave}>Spara en produkt</button>
      <button onClick={handleUpdate}>Uppdatera en produkt</button>
      <button onClick={handleDelete}>Ta bort en produkt</button>
      <button onClick={handleSelect}>Visa produkter</button>
      <p>{message}</p>
    </>
  );
};

export default ProductForm;
