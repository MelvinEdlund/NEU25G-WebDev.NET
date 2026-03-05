import "./App.css";

// Detta används för att mappa url med en pagekomponent
import Header from "./components/Header/Header";
import { Route, Routes } from "react-router";
import Home from "./components/pages/Home";
import Contact from "./components/pages/Contact";
import About from "./components/pages/About";
import NotFound from "./components/pages/NotFound";
import Products from "./components/pages/Products.tsx";
import ProductDetails from "./components/pages/ProductDetails.tsx";

function App() {
  // När man klickar på ett alternativ i navigering (Header) ändras url:en.
  //  Den kopplas till en route som mappar url:en med en pagekomponent
  return (
    <>
      <Header />
      <Routes>
        <Route path="/" element={<Home />}></Route>

        <Route path="/products" element={<Products />} />
        <Route path="/products/:id" element={<ProductDetails />}></Route>

        <Route path="/about" element={<About />}></Route>
        <Route path="/contact" element={<Contact />}></Route>
        <Route path="*" element={<NotFound />}></Route>
      </Routes>
    </>
  );
}

export default App;
