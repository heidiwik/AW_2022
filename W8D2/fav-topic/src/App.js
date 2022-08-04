import { useState } from 'react'
import { Header } from './components/Header'
import { Hello } from './components/Hello'



const App = () => {
  const [selection, setSelection] = useState("ei mikään :(");
  const [name, setName] = useState("Martti");

  console.log("State: " + selection);

  return (
    <div className='block main'>
      <Hello nimi={name} lempiaihe={selection} />

      <Header valinta={selection} />

      <p className="selection">Lempiaiheeni kurssilla on: {selection}</p>

      <p className="selection">Valitse uusi lempiaihe</p>
      <button onClick={() => setSelection("C#")}>C#</button>
      <button onClick={() => setSelection("React")}>React</button>
      <button onClick={() => setSelection("HTML & CSS")}>HTML & CSS</button>
      <button onClick={() => setSelection("JavaScript")}>JavaScript</button>
      <button onClick={() => setSelection("Databases")}>Databases</button>
    </div>
  )
};
 
export default App