import type { Comment } from "../../types/types";

interface CommentListProps {
	comments: Comment[];
}

// Här tar vi emot en lista med Comment objekt
const CommentList = ({ comments }: CommentListProps) => {
	// Loopar igenom listan och lägger ut värde på body på skärmen
	const list = comments.map((comment) => {
		return <li>{comment.body}</li>;
	});

	return <ul>{list}</ul>;
};

export default CommentList;
