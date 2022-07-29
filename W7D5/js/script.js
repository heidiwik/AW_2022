 
 function validateEmpty(val) {
  if (val == "" || val == null) {
    return false;
  }
  return true;
}



function validateForm() {

   var username = document.contactForm.username.value;
   var email = document.contactForm.email.value;
   var name = document.contactForm.name.value;
   var age = document.contactForm.age.value;

   var errors = [];

  if (!validateEmpty(name)) {
     errors.push("Name cannot be empty");
  }

  if (!validateEmpty(username)) {
    errors.push("Username cannot be empty");
  }

  if (isNaN(age)) {
    errors.push("Age must be number");
  }


  if (errors.length == 0) {

     // save data

  } else {

    document.getElementById("errorList").style.border = "3px solid red";

    console.log("Virhe löytyi");

    var errorText = "<p>Please fix errors:</p><ul>";
    errors.forEach(element => {
      errorText = errorText + "<li>" + element + "</li>";
    });
    errorText = errorText + "</ul>";

    document.getElementById("errorList").innerHTML = errorText;

    return false;
  }

};