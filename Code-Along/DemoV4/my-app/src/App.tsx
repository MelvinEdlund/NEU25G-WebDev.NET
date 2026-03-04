import './App.css';
import Person from './components/Person';
import type { PersonI } from './types/interfaces';

function App() {
  const exampleGuy: PersonI = {
    name: 'Melvin',
    age: 24,
    id: 1,
  };

  const exampleGal: PersonI = {
    name: 'Hanna',
    age: 26,
    id: 2,
    favoriteAnimal: 'Fisk',
  };

  const list: PersonI[] = [exampleGuy, exampleGal];

  if (exampleGuy.favoriteAnimal) {
    console.log('person', exampleGuy.favoriteAnimal.toUpperCase);
  }

  return (
    <>
      <div>People</div>

      <section>
        {list.map((listPerson) => (
          <Person key={listPerson.id} person={listPerson} />
        ))}
      </section>
    </>
  );
}

export default App;
