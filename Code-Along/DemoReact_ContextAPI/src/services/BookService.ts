import type { Book } from "../types/Types";

// Vi skickar in ett sökvillkor som är hela eller del av en boktitel
export const getBooks = async (condition: string) => {
  const url = "https://fakerapi.it/api/v2/books?_quantity=40";

  // Vi hämtar 40 böcker som vi sedan skall göra ett urval på
  const result = await fetch(url).then((response) => response.json());

  const books: Book[] = result.data.filter((book: Book) => {
    return book.title.includes(condition);
  });

  return books;
};
