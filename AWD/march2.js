/*
 * This is a JavaScript Scratchpad.
 *
 * Enter some JavaScript, then Right Click or choose from the Execute Menu:
 * 1. Run to evaluate the selected text (Ctrl+R),
 * 2. Inspect to bring up an Object Inspector on the result (Ctrl+I), or,
 * 3. Display to insert the result in a comment after the selection. (Ctrl+L)

var myDate = new Date();
myDate.setFullYear(2010, 0, 14);
var today = new Date();
if(myDate > today)
  alert("Today is before 14 Jan 2010");
else
  alert("Today is after 14 Jan 2010");



var str = "Hello how are you?";
var pos = str.indexOf("how");
console.log(pos);



var str = "Please locate where 'locate occurs!";
var pos = str.lastIndexOf("locate");
console.log(pos);


var str = "Apple, Banana, Kiwi";
var r = str.slice(7, 13);
var x = str.slice(-12, -6);
var z = str.slice(7);
console.log(r);
console.log(x);
console.log(z);
var a = str.substr(7, 6);
console.log(a);

*/

var str1 = "Hello ";
var str2 = "Good Morning";
console.log(str1);
console.log(str2);
console.log(str1.concat(str2));