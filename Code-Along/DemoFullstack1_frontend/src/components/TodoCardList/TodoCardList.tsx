
import type { Todo } from "../../types/Types";
import TodoCard from "../TodoCard/TodoCard";

interface TodoCardListProps{
    todos:Todo[]
}

const TodoCardList = ({todos}: TodoCardListProps) =>{

    //Vi loopar igenom alla todos som vi får från sökningen och ritar 
    //upp TodoCards för dessa
    const list = todos.map(todo => {
        return(<TodoCard todo= {todo} />)
    });

    return (<>{list}</>)

}

export default TodoCardList;
