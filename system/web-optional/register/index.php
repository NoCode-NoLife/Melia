<?php

require_once 'functions.php';

$submitted = false;
$error = false;

if (isset($_POST['register']))
{
	$username = $_POST['username'] ?? '';
	$password1 = $_POST['password1'] ?? '';
	$password2 = $_POST['password2'] ?? '';

	$submitted = true;

	$response = httpRequest('POST', baseUrl() . '/api/account/create/', json_encode([
		'username' => $username,
		'password1' => $password1,
		'password2' => $password2,
	]));

	if ($response === false)
	{
		$error = 'Failed to connect to the server.';
	}
	else
	{
		$response = json_decode($response, true);

		if ($response['result'] !== 0)
			$error = $response['error'] ?? 'An unknown error occurred.';
	}
}

render('register', [
	'submitted' => $submitted,
	'error' => $error,
]);
