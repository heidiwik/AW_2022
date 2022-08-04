const Total = (props) => {
console.log(props);

  return (
    <p>
      Number of exercises: {props.maara}
    </p>
  )
}

const Divider = () => {
  return (
    <><hr/></>
  )
}

const Header = (props) => {
  return (
    <div>
      { <h1>{props.kurssi}</h1> }
    </div>
  )
}

const Content = (props) => {

  console.log(props); 

  return (
    <div>
      {/* Parts here */}
    </div>
  )
}

const Part = (props) => {

  console.log(props);

  return (
    <div>
      <p><span className="ex-name">{props.part_name}</span> : Exercises {props.ex_amount}</p>
    </div>
  )
}


const App = () => {

  const course = {
    name: 'Half Stack application development',
    parts: [
      {
        name: 'Fundamentals of React',
        exercises: 10
      },
      {
        name: 'Using props to pass data',
        exercises: 7
      },
      {
        name: 'State of a component',
        exercises: 14
      }
    ],
    year: 2022,
    url: "fullstackopen.com"
  }

  console.log(course.url);




  return (
    <div>
      <Header kurssi={course} vuosi="2022" />

      <Divider />

      <Content osiolista={course}/>

      <Divider />

      <Total parts_list={course} />

    </div>
  )
}

export default App