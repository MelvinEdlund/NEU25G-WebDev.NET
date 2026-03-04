import { getPostComments } from "../../services/CommentService";
import { useState, useEffect } from "react";
import type { Comment } from "../../types/types";
import CommentList from "../CommentList/CommentList";

interface PostProps {
	id: number;
}

const Post = ({ id }: PostProps) => {
	// Vi skapar en statevariabel som skall hålla en lista med objekt av typen Comment
	const [comments, setComments] = useState<Comment[]>([]);

	// useEffect hanterar lifecycle events dvs events som triggas automatiskt av komponenten (inte direkt av en användare)
	// Arrayen i slutet kallas för dependency array och styr när och hur eventet skall fångas upp
	// En tom array innebär att eventet körs en gång, när komponenten initieras första gången
	useEffect(() => {
		// Första gången komponenten initieras hämtas alla kommentarer
		getPostComments(id).then((commentList) => {
			// Tar svaret och lägger in i state variabeln
			setComments(commentList);
		});
	}, []);

	return (
		<>
			<h3>Här visas info om posten</h3>
			<p>Här visas alla kommentarer</p>
			<CommentList comments={comments} />
		</>
	);
};

export default Post;
