import './App.css'
import ProductCard from './components/productCard/productCard'

function App() {

  //Detta kommer i vanliga fall från ett web api
  const product = {"image":"http://localhost:5173/src/assets/samsung_galaxy.png","brand":"Samsung","name":"Galaxy S23", "price":"10000","description":"Samsung Galaxy S23+ 5G smartphone har en elegant och modern design, fullspäckad med högklassig teknologi. Den är skyddad av Armour Aluminium-ramen och har därmed bättre skydd mot fall och stötar."};
  return (
    <>
      <ProductCard product={product} />
    </>
  )
}

export default App
