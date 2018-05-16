var correctEmail;
var correctPassword;
$('#clickLogin').click(function () {
	$.ajax({
		url: 'ShowPersonalInfo',
		type: 'GET',
		error: function () {
			console.log("Error");
		},
		success: function (data) {
			$('#personalInfo').append(data);
			$('#loginInfo').hide();
		}
	});
	event.preventDefault();
});

$('#email').change(function () {
	var email = $('#email').val();
	$('#emailMessage').empty();

	$.ajax({
		url: 'ValidateEmail',
		type: 'POST',
		data: {
			//__RequestVerificationToken: token,
			email: email
		},
		success: function (data) {
			$('#emailMessage').append('<span>' + data.message + '</span>');
			if (data.works) {
				correctEmail = true;
			} else {
				correctEmail = false;
			}
			if (correctEmail && correctPassword) {
				document.getElementById('clickLogin').disabled = false;
			} else {
				document.getElementById('clickLogin').disabled = true;
			}
		}

	});

	if (correctEmail && correctPassword) {
		document.getElementById('clickLogin').disabled = false;
	} else {
		document.getElementById('clickLogin').disabled = true;
	}
});

$('#passwordAgain').keyup(function () {
	var pass1 = document.getElementById('password');
	var pass2 = document.getElementById('passwordAgain');
	var nextButton = document.getElementById('clickLogin');
	//Store the Confimation Message Object ...
	var message = document.getElementById('passwordMessage');
	//Set the colors we will be using ...
	var goodColor = "#66cc66";
	var badColor = "#ff6666";
	//Compare the values in the password field 
	//and the confirmation field
	if (pass1.value == pass2.value) {
		//The passwords match. 
		//Set the color to the good color and inform
		//the user that they have entered the correct password 
		pass2.style.backgroundColor = goodColor;
		message.style.color = goodColor;
		message.innerHTML = "Passwords Match!";
		correctPassword = true;

	} else {
		//The passwords do not match.
		//Set the color to the bad color and
		//notify the user.
		pass2.style.backgroundColor = badColor;
		message.style.color = badColor;
		message.innerHTML = "Passwords Do Not Match!";
		correctPassword = false;
	}
	if (correctEmail && correctPassword) {
		document.getElementById('clickLogin').disabled = false;
	} else {
		document.getElementById('clickLogin').disabled = true;
	}

});