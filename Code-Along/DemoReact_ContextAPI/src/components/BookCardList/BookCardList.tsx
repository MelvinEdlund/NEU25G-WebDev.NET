import { BookContext } from "../../contexts/BookContext";
import { useContext } from "react";
import type { BookContextType } from "../../types/Types";

import BookCard from "../BookCard/BookCard";

// Här skickas inte data in som props utan hämtas direkt från providern
const BookCardList = () => {
  const { books } = useContext(BookContext) as BookContextType;

  const list = books.map((book) => {
    return <BookCard key={book.id} book={book} />;
  });

  return <>{list}</>;
};

export default BookCardList;
