
// Assignment (2): Assign a string value to a variable  
var A = "Joe ", B = "Blow";

//  Assignment (1): Utilize the window.alert() methods.
window.alert(A + B);

D = 23;
E = 34;
// Assignment (4): Write an expression.
var F = D * E;

// Assignment (1): Utilize the document.write() methods.
document.write("D x E = ", F);


// Assignment (5): Add comments throughout your JavaScript explaining your code

/* Assignment (3): Assign a color to at least one variable using the fontcolor() method.

  The fontcolor() method is deprecated in JavaScript.
  https://www.w3schools.com/jsref/tryit.asp?filename=tryjsref_str_fontcolor    
  
    I used the getElementById method instead:
    document.getElementById("p2").style.color = "Blue";
    I could not manage to use it in the external script file: main.js
    
  */


function displayDate(){
  document.getElementById("p3").innerHTML = Date();
}