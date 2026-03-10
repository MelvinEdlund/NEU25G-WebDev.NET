import { useContext, useRef } from "react";
import { BookContext } from "../../contexts/BookContext";
import "./Search.css";
import BookCardList from "../BookCardList/BookCardList";

// Detta kallas för en consumer eftersom den använder funktionalitet som providern hanterar
const Search = () => {
  const textVal = useRef<HTMLInputElement>(null);
  const context = useContext(BookContext);

  if (!context) throw new Error("Not a valid provider");

  // Vi talar om att vi vill kunna komma åt en eventhandler som finns i providern
  const { searchBooks } = context;

  const handleClick = () => {
    // Här görs en sökning av böcker med texten i textboxen
    if (textVal.current) searchBooks(textVal.current.value);
  };

  return (
    <>
      <div id="search">
        <input type="text" ref={textVal} />
        <button onClick={handleClick}>Sök</button>
      </div>
      <BookCardList />
    </>
  );
};

export default Search;
