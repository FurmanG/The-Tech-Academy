// Intentionally write a function with an error in it and use console.log() method to debug it within the console in Chrome Dev Tools.

// Write a global variable.
var A = 10, B = 15;
function addNumbers_1(){
  document.write( A + B + "<br><br>");
}
function addNumbers_2(){
  document.write( A * B + "<br><br>");
}
addNumbers_1()
addNumbers_2()

// Write a local variable.
function addNumbers_3(){
  var C = 65, D = 35;
  document.write( C + D + "<br><br>");
}
addNumbers_3()

//write a function with an error in it and use console.log() method to debug it
var E = 34;
function addNumbers_4(){
  var F = 76;
  document.write( E * F + "<br><br>");
  console.log(E * F)
}
function addNumbers_5(){
  document.write(E * F + "<br><br>");
  console.log(E * F)
}
addNumbers_4()
addNumbers_5()

//Write out a function with an if statement that utilizes the new Date().getHours() method.
//Write out a document.getElementById() method, reference the id attribute in the HTML file.
function whatToGreet(){
  var timeNow = new Date().getHours();
  if (timeNow > 1 && timeNow < 12 ){
    document.getElementById("greetNow").innerHTML = "Good Morning!!";
  } else if (timeNow >= 12 && timeNow <= 18){
    document.getElementById("greetNow").innerHTML = "Good Afternoon!!";
  } else{
    document.getElementById("greetNow").innerHTML = "Good Night!!";
  }
}



/* ====================================================================*/
//1. Write a function that includes an if statement and an else statement.2. Write the relevant document.getElementById() methods
function affordableCar(){
  var Budget = document.getElementById("myBudget").value;
 if (Budget < 10000){
    document.getElementById("typeOfCar").innerHTML = " = Vespa :( ";
  }
  else if (Budget > 10000 && Budget <= 30000 ){
    document.getElementById("typeOfCar").innerHTML = "== Toyota ==";
  } 
  else if (Budget > 30000 && Budget <= 50000){
    document.getElementById("typeOfCar").innerHTML = "==== Acura ====";
  } 
  else{
    document.getElementById("typeOfCar").innerHTML = "=*=*=*=*= BMW =*=*=*=*=";
  }
}
