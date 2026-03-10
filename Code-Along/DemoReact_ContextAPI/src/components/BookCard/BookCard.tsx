import "./BookCard.css";
import type { Book } from "../../types/Types";

interface BookCardProps {
  book: Book;
}

const BookCard = ({ book }: BookCardProps) => {
  const handleClick = () => {
    alert("Här visas detaljer tex genom en navigering till en detaljkomponent");
  };

  return (
    <div className="bookstyle">
      <h4>{book.title}</h4>
      <p>{book.description}</p>
      <button onClick={handleClick}>Visa detaljer</button>
    </div>
  );
};

export default BookCard;
