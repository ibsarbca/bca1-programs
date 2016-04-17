function isNameValid(input) {
	var regex = "/^(\w+[ \w]){2}$/";
	// This text matches two words, that can include numbers
	if(regex.match(input.value))
		return true;
	else
		return false;
}


function isNumValid(input) {
	
	var regex = "/\d{1,5}/";
	// This pattern matches numbers that are a minimum of 1 digit
	// long and have a maximum of 5 digits
	if(regex.match(input.value))
		return true;
	else
		return false;
}

function checkform(f1) {
	if(isNameValid(f1.txtName.value) && isNumValid(f1.txtNo.value)) {
		return true;
	} else {
		var error_text =	 document.getElementById("errorText");
		error_text.innerHTML = "Error: Name or Phone number not valid";
		return false;
	}
}

