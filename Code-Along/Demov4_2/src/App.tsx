import "./App.css";
import { useEffect, useState } from "react";
import type { Post } from "./types";
import { getAllPosts } from "./services/postsService";
import PostItem from "./components/PostItem";

function App() {
  const [posts, setPosts] = useState<Post[]>([]);

  const fetchPosts = () => {
    getAllPosts().then((posts) => setPosts(posts));
  };

  useEffect(() => {
    fetchPosts();
  }, []);

  return (
    <div>
      <h2>Posts</h2>
      <button onClick={fetchPosts}>Fetch Posts</button>

      {posts.map((post) => (
        <PostItem key={post.id} post={post} />
      ))}
    </div>
  );
}

export default App;
