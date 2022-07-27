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