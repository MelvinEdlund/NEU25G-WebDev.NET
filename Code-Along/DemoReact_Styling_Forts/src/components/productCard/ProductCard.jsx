
import './ProductCard.css';
//Färdig komponent som följer med React-bootstrap för att hantera tex produktcards eller contactcard 
//React-bootstrap laddas ned med npm install React-bootstrap
import {Card} from 'react-bootstrap';

const ProductCard = ({product}) => {

    const handleClick = () => {

        alert(`Du har valt produkten ${product.name}`);

    }

    //Webbdesign med egen css + bootstrap
    return(<Card className='h-100 product-card' border='light'>
                <Card.Img
                    variant="top"
                    src={product.image}
                    className='product-image'
                    onClick={handleClick}
                />
                <Card.Body>
                    <Card.Title>{product.brand}</Card.Title>
                    <Card.Text>{product.name}</Card.Text>
                </Card.Body>
                <Card.Footer>
                    <h5 className='fw-bold'>{product.price}</h5>
                </Card.Footer>
            </Card>)
}

export default ProductCard;