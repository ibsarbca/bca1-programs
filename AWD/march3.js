// Reverse a string
var mystring = prompt('Enter string: ');
mystring = mystring.split('');
// document.write(mystring + "<br />");

var temp = mystring.reverse();

mystring = temp.join('');
document.write(mystring + "<br />");

// Print even numbered elements
var friends = [1,2,3,4,5,6,7,8,9,10];

for(var i = 0; i < friends.length; i++) {
	if(i % 2 === 0)
		document.write(friends[i]);
}
