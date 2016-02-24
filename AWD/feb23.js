/*
 * This is a JavaScript Scratchpad.
 *
 * Enter some JavaScript, then Right Click or choose from the Execute Menu:
 * 1. Run to evaluate the selected text (Ctrl+R),
 * 2. Inspect to bring up an Object Inspector on the result (Ctrl+I), or,
 * 3. Display to insert the result in a comment after the selection. (Ctrl+L)
 */


// SWITCH CASE
var switch_case = function() {
  var day;
  switch (new Date().getDay()) {
    case 0:
      day = "sun";
      break;
    case 1:
      day = "mon";
      break;
    case 2:
      day = "tue";
      break;
    case 3:
       day = "wed";
      break;
    case 4:
      day = "thu";
      break;
    case 5:
      day = "fri";
      break;
    case 6:
      day = "sat";
      break;    
  }  

  document.write("Today is: " + day); 
}
switch_case();
document.write("<br />");

// DEFAULT
var switch_case_default = function() {
  var day;
  switch (new Date().getDay()) {
    case 0:
      day = "sun";
      break;
    case 6:
      day = "sat";
      break;
    default:
      day = "NOT A WEEKEND";
      break;
  }  

  document.write("Today is: " + day + "<br />"); 
}
switch_case_default();

// SCOPE 

var x = 10;
document.write(typeof x + "<br />");

var foo = function() {
  x = "Hello";
  
  document.write(x);
}
foo();

// EXECUTION


