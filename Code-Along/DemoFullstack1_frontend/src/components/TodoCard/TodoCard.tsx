import type { Todo } from "../../types/Types";
import './TodoCard.css';

interface TodoCardProps{
    todo: Todo
}

//Detta är en UI/presentations komponent som inte har logik och state
const TodoCard = ({todo}: TodoCardProps) => {

    //Ritar upp ett TodoCard
    return (<div className="todoStyle">

        <h3>{todo.title}</h3>
        <p>{todo.id}</p>

    </div>
    );

}

export default TodoCard;
