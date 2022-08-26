// Utilize the concat() and slice() method to connect two or more strings. 
function listOfName(){
  var A = "Sneezy B, ";
  var B = "Sleepy D, ";
  var C = "Dopy E, ";
  var D = "Grumpy V, ";
  var listName = A.concat(B, C, D);
  var secondName = listName.slice(10,19);
  document.getElementById("name_list").innerHTML = listName;
  document.getElementById("second_name").innerHTML = secondName;
}

// Write and execute the toUpperCase() method.
function changeToUpper(){
  var Hellow = "Hellow World!!!!";
  Hellow = Hellow.toUpperCase();
  document.getElementById("to_up_case").innerHTML = Hellow;
} 

// Write and execute the search() method.
function textSearch(){
  var Hellow = "Hellow World!!!!";
  wPosition = Hellow.search("w");
  document.getElementById("search_w").innerHTML = wPosition;
}

// Utilize the toString() method to return a number as a string.
function to_String(){
  var X = 324;
  var X_as_string = X.toString();
  document.getElementById("to_string").innerHTML = X.toString() + "<br>" + typeof(X_as_string);
}

// Utilize the toPrecision() method to return a string as a number of a specified length.
function to_Precision(){
  var X = 3.123456789;
  document.getElementById("to_Precision").innerHTML = X.toPrecision(4);
}

// Write and execute the toFixed() method.
function to_Fixed(){
  var X = 3.123456789;
  var X_fixed = X.toFixed(2);
  document.getElementById("to_Fixed").innerHTML = X_fixed + "<br>" + typeof(X_fixed);
}

