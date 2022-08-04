const Hello = (props) => {
    return (
      <div className='block hello'>
         <h1>Moi {props.nimi}!</h1>
         <img src={require('../assets/images/kissa.jpg')} />
         <p>Lempiaihe Tervehdys-komponentissa: {props.lempiaihe}</p>
      </div>
    )
  }

  export {Hello}