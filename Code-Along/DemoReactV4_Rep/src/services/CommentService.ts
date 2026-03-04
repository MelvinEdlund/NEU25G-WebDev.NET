// Tanken med service filer är att lägga all kod som anropar web api på ett ställe. Viktigt att separera detta från komponenter

export const getPostComments = async (id: number) => {
	const url =
		"https://jsonplaceholder.typicode.com/posts/" + id + "/comments";

	//Här går vi in i response objektet och tar fram vilken JSON data som skickades med i bodyn
	return await fetch(url).then((response) => response.json());
};

// Här läggs även andra anrop mot web apet som har med comments att göra tex att lägga till en ny comment eller ta bort
