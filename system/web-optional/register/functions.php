<?php

function conf($option, $value = null)
{
	static $config = [];

	if ($value === null)
		return isset($config[$option]) ? $config[$option] : null;

	$config[$option] = $value;
}

function render($template, $data = [])
{
	$templatePath = 'templates/' . $template . '.php';

	if (!file_exists($templatePath)) {
		echo "<pre>Template not found: {$template}</pre>";
		return;
	}

	extract($data);
	include $templatePath;
}

function httpRequest($method, $url, $data = false)
{
	$curl = curl_init();

	switch ($method)
	{
		case "POST":
		{
			curl_setopt($curl, CURLOPT_POST, 1);

			if ($data)
				curl_setopt($curl, CURLOPT_POSTFIELDS, $data);
			break;
		}
		case "PUT":
		{
			curl_setopt($curl, CURLOPT_PUT, 1);
			break;
		}
		default:
		{
			if ($data)
				$url = sprintf("%s?%s", $url, http_build_query($data));
		}
	}

	curl_setopt($curl, CURLOPT_URL, $url);
	curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);

	$result = curl_exec($curl);

	if($result === false)
		trigger_error(curl_error($curl));

	curl_close($curl);

	return $result;
}

function baseUrl()
{
	$protocol = isset($_SERVER['HTTPS']) && $_SERVER['HTTPS'] === 'on' ? 'https://' : 'http://';
	$host = $_SERVER['HTTP_HOST'];

	return $protocol . $host;
}
