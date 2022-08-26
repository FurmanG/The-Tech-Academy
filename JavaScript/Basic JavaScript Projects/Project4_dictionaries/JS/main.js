
// Data of a student stored in a dictionary
Student = {
  name:"Doc Timon",
  age:23,
  class:"Chemistry",
  Score:"A+"
}
// Deleting an item from the dictionary list
delete Student.age 
// A function that sends the student's age to the HTML page
function getAge(){
  document.getElementById("Dictionary").innerHTML = Student["age"];
}