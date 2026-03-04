import Box from './components/Box/Box';

import './App.css'

function App() {

  return (
    <>
      <Box height="300px" width="200px" color="lightyellow" border={true}/>
      <Box height="50px" width="50px" color="black" border={false}/>
      <Box height="100px" width="200px" color="red" border={true}/>
      <Box height="200px" width="100px" color="blue" border={false}/>

    </>
  )
}

export default App
