// LOOPS ASSIGNMENT
function Call_Loop(){
  var Digit ="";
  var X = 0;
  while(X < 10){
    Digit += "<br>" + X;
    X++;
  }
  document.getElementById("Loop").innerHTML=Digit;
}

// LENGTH PROPERTY CHALLENGE
function Length_String(){
  var text = "Hellow World!!";
  var length_string = text.length; 
  console.log(text);
  console.log(length_string);
  document.getElementById("len").innerHTML= "The length of " + text + " is " + length_string;
}

// FOR LOOP ASSIGNMENT
var instruments = ["Guitar","Drums","Piano","Bass","Violin","Trumpet","Flute"];
var Content = "";
var Y;
function for_Loop(){
  for (Y = 0; Y < instruments.length; Y++){
    Content += instruments[Y] + "<br>";
  }
  document.getElementById("List_of_Instruments").innerHTML = Content;
}

// DOCUMENT.GETELEMENTBYID().INNERHTML ASSIGNMENT
 function array_Function(){
   var names =[];
   names[0]="Mufasa"
   names[1]="Simba"
   names[2]="Nala"
   names[3]="Kiara"
   document.getElementById("Array").innerHTML = "Her name is : " + names[2] + ".";
 }

// CONST KEYWORD ASSIGNMENT
function constant_function(){
  const vehicle = {type : "Fiat", Model : "Mini Cooper",  color : "Green", year : 2022};
  document.getElementById("Constant").innerHTML = "Year = " + vehicle.year;
  vehicle.year = 2023;
  vehicle.price = "$20,000";
  document.getElementById("Constant").innerHTML =  "Year = " + vehicle.year  +  " Price = " + vehicle.price;
}

// LET KEYWORD ASSIGNMENT
function let_assignment(){
var A = 88;
document.write(A);
{
  let A = 14;
  document.write("<br>" + A);
}
document.write("<br>" + A);
}

// RETURN STATEMENT CHALLENGE
document.getElementById("greet").innerHTML = greeting_function("Smith");
function greeting_function(name){
  return "Hello " + name;
}

// OBJECT ASSIGNMENT
let student = {
  Name : "Joe",
  Age : 24,
  Class : "Chemistry",
  University : "USF",
  Data : function(){
    return "Student: " + this.Name + " / age: " + this.Age + " / Class: " + this.Class + " / Unversity: " + this.University;
  }
};
document.getElementById("student").innerHTML = student.Data();

// BREAK AND CONTINUE CHALLENGE
let text_1 = "";
for (let i = 0; i < 12; i++){
  if(i === 4){ break;}
  text_1 += "The wining number is " + i + "<br>";
}
document.getElementById("Break").innerHTML = text_1;
   // CONTINUE
let text_2 = "";
for (let i = 0; i < 6; i++){
  if(i === 4){ continue;}
  text_2 += "The wining number is " + i + "<br>";
}
document.getElementById("Continue").innerHTML = text_2;

