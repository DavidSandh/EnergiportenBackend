$(document).on('change', '#autocomplete', function () {
	$('#personalInfo').find('#address-form').show();
	$('#personalInfo').find('#address-autocomplete').remove();
});

$('#clickPersonal').click(function () {
	$.ajax({
		url: 'ShowBrfSelect',
		type: 'GET',
		error: function () {
			//$('#info').html('<p>An error has occurred</p>');
		},
		success: function (data) {
			console.log('success');
			$('#brfInfo').append(data);
			$('#personalInfo').hide();
		}
	});
	event.preventDefault();
});