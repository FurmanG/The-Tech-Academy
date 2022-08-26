// Write a function using HTML and JavaScript that utilizes a ternary operation using input from the browser.
//If they are under 18, “You are not old enough to vote”. If they are 18 or older, “You can vote!”
function voteAge(){
  var Age, Can_vote;
  Age = document.getElementById("age").value;
  Can_vote = (Age >= 18) ? "You can":"You are not old enough to";
  document.getElementById("Vote").innerHTML = Can_vote + " vote!. ";
}

// Write a constructor function that uses the “new” and “this” keywords
//OBJECT-ORIENTED Class with constructor
function Vehicle(Make, Model, Year, Color){
  this.Vehicle_Make = Make;
  this.Vehicle_Model = Model;
  this.Vehicle_Year = Year;
  this.Vehicle_Color = Color;
}
// Three instance (objects) of the class Vehicle
var Jack = new Vehicle("Dodge", "Viper", 2020, "Red");
var Emily = new Vehicle("Jeep", "Trail", 2019, "White and Black");
var Erik = new Vehicle("Ford", "Pinto", 1971, "Mustard");

// Create a function to display the results of the constructor function within an HTML element 
// outputs the instance (object) Erik of the class Vehicle
function myFunction(){
  document.getElementById("Keywords_and_Constructors").innerHTML = "Erik drive a " + Erik.Vehicle_Color + "-colored " + Erik.Vehicle_Model + " manufactured in " + Erik.Vehicle_Year+".";
}

// Write a nested function
// add2Nmbers() is nested functions.
function nestFunction(){
  document.getElementById("Nested_Function").innerHTML = addFunction();
  function addFunction(){
    var A = 53453;
    var B = 64637;
    function add2Nmbers(){A = A + B;}
    add2Nmbers();
    return A;  
  }
}

