import type { PersonI } from "../types/interfaces";

interface PersonProps {
    person: PersonI;
}

const Person: React.FC<PersonProps> = ({person}) => {
  return (
  <article>
        <h1>{person.name}</h1>

        <div>{person.age}</div>

        <div> 
            {person.favoriteAnimal ? person.favoriteAnimal : "No favorite Animal"}
        </div>
    </article>
  
    );
}

export default Person
