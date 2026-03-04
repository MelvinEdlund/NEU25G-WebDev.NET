import type { Post } from "../types";

export const getAllPosts = async () => {
  const url = "https://jsonplaceholder.typicode.com/posts";

  const response = await fetch(url);

  if (!response.ok) {
    throw new Error(`HTTP error! status: ${response.status}`);
  }

  const data: Post[] = await response.json();

  return data;
};
