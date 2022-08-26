// Example of math operators
function mathOperators(){
  var A = 1, B = 7, C = 30, D = 12 , E = 4;
  var F = (((B - A) * C )/ D) % E;
  var G = 12;
  G++;
  document.getElementById("math").innerHTML = "F = (((B - A) x C )/ D) % E  = " + F + "<br>F x (-1) = " + -F  + "<br>G=12 and G++ = " + G;
}

// Example of math random function
function randomNumber(){
 document.getElementById("random").innerHTML = window.alert(Math.random() * 101);
}

// Example of math squared function
function squared(){
  document.getElementById("sqrt2").innerHTML = window.alert(Math.sqrt(9));
 }

