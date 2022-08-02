import { useState } from 'react'

const App = () => {
  const [selection, setSelection] = useState("ei mikään :(");

  return (
    <>
      <h2>Lempiaiheeni kurssilla on: {selection}</h2>

      <p></p>
      <p>Valitse lempiaihe:</p>
      <button type="button" onClick={() => setSelection("C#")}>C#</button>
      <button type="button" onClick={() => setSelection("React")}>React</button>
      <button type="button" onClick={() => setSelection("HTML & CSS")}>HTML & CSS</button>
      <button type="button" onClick={() => setSelection("JavaScript")}>JavaScript</button>
    </>
  )
};
 
export default App
