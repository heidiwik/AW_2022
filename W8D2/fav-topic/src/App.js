import { useState } from 'react'

const App = () => {
  const [selection, setSelection] = useState("ei mikään :(");

  return (
    <>
      <h2>Lempiaiheeni kurssilla on: {selection}</h2>

      <p></p>
      <p>Valitse lempiaihe:</p>
      <button onClick={() => setSelection("C#")}>C#</button>
      <button onClick={() => setSelection("React")}>React</button>
      <button onClick={() => setSelection("HTML & CSS")}>HTML & CSS</button>
      <button onClick={() => setSelection("JavaScript")}>JavaScript</button>
      <button onClick={() => setSelection("Databases")}>Databases</button>
    </>
  )
};
 
export default App