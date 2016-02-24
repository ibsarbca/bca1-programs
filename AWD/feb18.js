/*
 * This is a JavaScript Scratchpad.
 *
 * Enter some JavaScript, then Right Click or choose from the Execute Menu:
 * 1. Run to evaluate the selected text (Ctrl+R),
 * 2. Inspect to bring up an Object Inspector on the result (Ctrl+I), or,
 * 3. Display to insert the result in a comment after the selection. (Ctrl+L)
 */

/* Programs as of Feb 18:

1. Max out of 3 numbers.

2. Sum of first 5 even numbers.

3. Squares from one to 10.

4. Accept number from user and print whether it is prime or not.

*/


console.log("MAX NUMBERS between 2, 3 and 4: ");

var max_number = function(n1, n2, n3) {
  num = n1;
  var list = [n1, n2, n3];
  for(var x = 0; x < list.length; x++) {
    if (num < list[x]) {
      num = list[x];
    }
  }
  return num;
}
console.log(max_number(2,3,4));


var sum_of_even_numbers = function() {
  var sum = 0;
  for(var x = 0; x < 11; x++) {
    if(x % 2 === 0)
     sum += x;
  }
  return sum;
}

console.log("SUM OF EVEN NUMBERS:");
console.log(sum_of_even_numbers());

var squares = function() {
  for(var x = 1; x < 11; x++) {
    console.log(x*x);
  }
}

console.log("SQUARES: ");

squares();

console.log("PRIME: ");

var prime = function(value) {
  for(var i = 2; i < value; i++) {
    if(value % i === 0)
      return false;
    else
     return true;
  }
}

var num = prompt("Enter number to check if prime: ");
if(prime(num)) {
  console.log(num +" is PRIME");
}
else {8

  console.log(num + " is NOT PRIME");
}

