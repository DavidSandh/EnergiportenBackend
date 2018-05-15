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
        }
    });
});

$('#passwordAgain').keyup(function () {
    var password = $('#password').val();
    var passwordAgain = $('#passwordAgain').val();
    $('#passwordMessage').empty();

    if (password != passwordAgain) {
        $('#passwordMessage').append('<span>Lösenorden matchar inte varandra</span>');
    } else {
        $('#passwordMessage').append('<span>Lösenorden matchar varandra</span>');
    }
});