// Source: https://fullstackopen.com/osa7/react_router

import React, { useState }  from 'react'
import ReactDOM from 'react-dom/client'
import {
  BrowserRouter as Router,
  Routes, Route, Link
} from "react-router-dom"

const Home = () => (
  <div> <h2>TKTL notes app</h2> </div>
)

const Notes = () => (
  <div> 
    <h2>Notes</h2> 
    <p> I'm baby prism tbh craft beer 90's mumblecore raw denim tacos cronut palo santo schlitz keffiyeh direct trade tumblr vice. Squid bespoke forage cold-pressed, waistcoat activated charcoal gochujang. Godard squid blog chartreuse cray tousled. Unicorn shaman intelligentsia, williamsburg yes plz retro iPhone single-origin coffee woke seitan DIY brooklyn literally cronut PBR&B.</p>
  </div>
)

const Users = () => (
  <div> <h2>Users</h2> 
  <p>Health goth prism plaid, man braid butcher schlitz tumeric. Organic hammock marfa, tattooed fixie palo santo irony chillwave cliche vexillologist. Vape synth chambray live-edge. Hashtag waistcoat copper mug, artisan hammock authentic vice mlkshk. Lyft thundercats affogato knausgaard, tumblr adaptogen craft beer. DIY YOLO XOXO fixie. Disrupt cold-pressed XOXO stumptown YOLO waistcoat af chartreuse semiotics health goth pitchfork biodiesel four dollar toast. Tofu pug tilde jean shorts, snackwave coloring book selfies sriracha green juice godard plaid intelligentsia. Pour-over lumbersexual raclette wolf godard pug. Letterpress kitsch swag DIY edison bulb, art party mumblecore irony food truck. Prism health goth palo santo tonx offal, kitsch heirloom pok pok. Hella crucifix intelligentsia ennui craft beer cliche asymmetrical cardigan heirloom microdosing hoodie banjo pitchfork. Four loko tacos chia mumblecore shoreditch. Yr bespoke chicharrones chambray church-key four dollar toast fixie.</p>
  </div>
)

const App = () => {
  const padding = {
    padding: 5
  }

  return (
    <Router>
      <div>
        <Link style={padding} to="/">home</Link>
        <Link style={padding} to="/notes">notes</Link>
        <Link style={padding} to="/users">users</Link>
      </div>

      <Routes>
        <Route path="/notes" element={<Notes />} />
        <Route path="/users" element={<Users />} />
        <Route path="/" element={<Home />} />
      </Routes>

      <div>
        <i>Note app, Department of Computer Science 2022</i>
      </div>
    </Router>
  )
}
export default App;
