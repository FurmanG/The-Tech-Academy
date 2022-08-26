
A = 3;
B = "String";

//utilize type coercion, Write an expression combining a string and a number
function typeCoercion(){
  document.getElementById("coercion").innerHTML = alert(B + 3) ;
}

// “document.write()” method and “type of” operator to display the data type of a variable
function typeOf(){
  document.getElementById("type").innerHTML = alert(typeof B);
}

// A large enough number to display “Infinity” and “-Infinity”
function isItPositiveInfinity(){
  document.getElementById("positiveInfinity").innerHTML = alert(3E320) ;
}

// A large enough negative number to display “-Infinity”
function isItNegativeInfinity(){
  document.getElementById("negativeInfinity").innerHTML = alert(-3E320) ;
}

// Boolean logic to display true and false.
function boolean(){
  document.getElementById("logic").innerHTML = alert(10>2 && 23>5) ;
  document.getElementById("logic").innerHTML = alert(10==2 || 23>5) ;
}

//perform a math operation with the console.log() function.
console.log(4+16);

// utilize > to return “false".
console.log(2>10);

//utilize == to return “true” and “false.”
document.write(10==10);
document.write(1==10);

//utilize === to return true by ensuring to match the data type and value.
document.write("AB"==="AB");

//utilize === to return false by writing a different data type and different value.
document.write("A"===10);

//utilize === to return false by writing a different data type but the same value for both.
document.write(5==="5");

//utilize === to return false by writing the same data type but a different value for both.
document.write(5===6);

//utilize the AND operator to display true and false.
document.write(6>5 && 2<5);
document.write(6>5 && 2>5);

//Utilize the OR operator to display true and false
document.write(6>5 || 2>5);
document.write(6<5 || 2>5);

//utilize the NOT operator to display true and false.
function notFunction1(){
  document.getElementById("Not1").innerHTML = alert (!(5 < 2));
}
function notFunction2(){
  document.getElementById("Not2").innerHTML = alert (!(5 > 2));
}