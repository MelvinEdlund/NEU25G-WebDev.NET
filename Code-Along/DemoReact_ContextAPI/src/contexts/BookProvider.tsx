// Detta är en global statehanteringskomponent
import { getBooks } from "../services/BookService";
import type { Book } from "../types/Types";
import { BookContext } from "./BookContext";
import { useState } from "react";

const BookProvider: React.FC<{ children: React.ReactNode }> = (props) => {
  const [books, setBooks] = useState<Book[]>([]);

  const searchBooks = (condition: string) => {
    getBooks(condition).then((result) => setBooks(result));
  };

  // Alla komponenter i appen skickas in som props till providern. Här exponerar vi providern
  // för alla komponenter i trädet dvs children.
  return (
    <BookContext.Provider value={{ books, searchBooks }}>
      {props.children}
    </BookContext.Provider>
  );
};

export default BookProvider;
