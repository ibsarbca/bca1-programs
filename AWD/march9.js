/*
 * This is a JavaScript Scratchpad.
 *
 * Enter some JavaScript, then Right Click or choose from the Execute Menu:
 * 1. Run to evaluate the selected text (Ctrl+R),
 * 2. Inspect to bring up an Object Inspector on the result (Ctrl+I), or,
 * 3. Display to insert the result in a comment after the selection. (Ctrl+L)
 */

// calculate the product of digits using while loop between 1 to 10 nos.
/*
1 * 2 * 3 ... 10
*/

// Take day as number input from user and show the day
/*
Eg: 1 - Monday, 2 - Tuesday
*/

var days = {
  1 : 'Monday',
  2 : 'Tuesday',
  3 : 'Wednesday',
  4 : 'Thursday',
  5 : 'Friday',
  6 : 'Saturday',
  7 : 'Sunday'
};

var input = prompt('Enter a number: ');
document.write(days[input] + "<br />");

/*
Exception: ReferenceError: docoument is not defined
@Scratchpad/1:31:1
*/

var i = 1;
var prod = 1;
while(i < 10) {
  prod = prod * i;
  i++;
  document.write(prod + "<br />")
}
/*
Print primes between 250 and 450
*/

var isPrime = function(n) {
  
  for(var i = 2; i < n; i++) {
    if (n % i == 0)
      return false;
  }
  return true;
}

for(var i = 250; i < 450; i++)
  if(isPrime(i))
    document.write(i + "<br />");4

/*
Define an array to store 5 email addresses in JS
*/
    
var emails = [
  'a@b.com',
  'b@c.com',
  'd@e.com',
  'e@f.com',
  'f@g.com'
];

for(var i = 0; i < emails.length; i++)
  document.write(emails[i] + '<br />');
