// en TS fil är inte en komponent utan en JS fil med typescript

// Vi har skapat en egen typ som vi använder för att ta emot data från ett web api och
// hantera data i komponenter

export interface Comment {
  postId: number;
  id: number;
  name: string;
  email: string;
  body: string;
}
