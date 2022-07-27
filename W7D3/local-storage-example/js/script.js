localStorage.setItem("testi", "terkkuja localStoragesta o/");


window.addEventListener('load', () => {
  const elem = document.getElementById('title')
  elem.style.color = localStorage.getItem("selectedColor");
});


function changeTextColor(color) {
    console.log(color);
    localStorage.setItem("selectedColor", color);
    const elem = document.getElementById('title');
    elem.style.color = color;
} 


// JSON stringify example

const userSelection = {
  color: "#ff000",
  language: "FI",
  news: 5,
  showAds: false
}

// convert object to JSON string
const userSelectionString = JSON.stringify(userSelection);
console.log(userSelectionString);

// save to localStorage
localStorage.setItem("userSelectionObject", userSelectionString);


// get from localStorage
var selection = localStorage.getItem("userSelectionObject");

// parse back to object
var selectionObject = JSON.parse(selection);

console.log(selectionObject.showAds);
