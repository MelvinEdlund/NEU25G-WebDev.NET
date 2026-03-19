import './Search.css';
import type { Todo } from '../../types/Types';
import { useRef,useState } from 'react';
import TodoSearch from '../../services/TodoService';
import TodoCardList from '../TodoCardList/TodoCardList';

//Detta är logik komponenten som innehåller state. Kommer att hämta data via web api:et
const Search = () => {

    //En state variabel har ett valfritt namn. Funktionen bör ha samma namn fast set i början
    //Här är det en lista med Todo objekt och startvärde är en tom array
    const[todoList, setTodoList] = useState<Todo[]>([]);

    const searchText = useRef<HTMLInputElement>(null);

    //En eventhandler som körs när man klickar på sökknappen
    const handleSearch = () =>{
        if(searchText.current)
        {
            //Hämta sökvillkor från textboxen
            const condition:string = searchText.current.value;

            //Vi anropar web api:et och lägger resultatet i state variabeln
            TodoSearch(condition)
            .then(todos => setTodoList(todos));
        }
    }

    //Data från sökningen som ligger i state variabeln skickas vidare till list komponenten 
    // visar alla träffar på webbsidan
    return(<>
             <div className='searchStyle'>
                <input type="text" ref={searchText} />
                <button onClick={handleSearch}>Sök</button>
            </div>
            <TodoCardList todos={todoList} />
           </>
    );


}

export default Search;
