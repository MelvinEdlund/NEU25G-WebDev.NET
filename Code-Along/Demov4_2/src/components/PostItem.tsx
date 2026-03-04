import type { Post } from "../types";

interface PostItemProps {
  post: Post;
}
const PostItem: React.FC<PostItemProps> = ({ post }) => {
  return <div>{post.title}</div>;
};

export default PostItem;
