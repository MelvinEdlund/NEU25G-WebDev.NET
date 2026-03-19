import type { Todo } from "../types/Types";

//Anrop till web api:er skall aldrig ligga direkt i komponenterna utan i
//servicefiler (som inte är komponenter utan ts filer)

//Eftersom det är ett asynkront anrop måste funktionen anpassas för det
const TodoSearch = async (condition: string) => {
  const url = "http://localhost:5114/api/todo/" + condition;

  //Ta ut den lista med todos som kommer från web api:et (i bodyn på responsen)
  const todos: Todo[] = await fetch(url).then((response) => response.json());

  //Gör urval för sökningen. Detta göra man alltid på servern i vanliga fall
  return todos.filter((todo) => todo.title.includes(condition));
};

export default TodoSearch;
