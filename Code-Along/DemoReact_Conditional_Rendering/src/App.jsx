import Greeting from './components/Greeting/Greeting'
import './App.css'

function App() {

  return (
    <>
      <Greeting isAdmin={true} is isLoggedIn={false} />
    </>
  )
}

export default App
