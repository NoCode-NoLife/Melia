<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">

	<title>Registration</title>

	<style>
		@import url('https://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.1/normalize.min.css');
		@import url('https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap');

		* {
			box-sizing: border-box;
			outline: none;
		}

		:root {
			--background-color: #f0f0f0;
			--form-color: #f9f9f9;
			--font-color: #333333;
			--textbox-color: #edf2f7;
			--button-color: #4338ca;
			--button-hover-color: #5b5fbb;
			--button-text-color: #f0f0f0;
		}

		@media (prefers-color-scheme: dark) {
			:root {
				--background-color: #121212;
				--form-color: #222222;
				--font-color: #f0f0f0;
				--textbox-color: #333333;
				--button-color: #4338ca;
				--button-hover-color: #5b5fbb;
				--button-text-color: #ffffff;
			}
		}

		html, body {
			height: 100%;
			width: 100%;
		}

		body {
			margin: 0;
			padding: 0;
			font-family: 'Roboto', Arial, sans-serif;
			font-size: 16px;
			background-color: var(--background-color);
			color: var(--font-color);
		}

		#main {
			display: flex;
			justify-content: center;
			align-items: center;
			text-align: center;

			height: 100%;
		}

		#main .content {
			display: flex;
			justify-content: center;
			align-items: center;
			
			width: 400px;
			border-radius: 8px;
			background-color: var(--form-color);
		}

		@media (max-width: 400px) {
			#main .content  {
				width: 100%;
				height: 100%;
			}
		}

		form {
			width: 100%;
			padding: 30px;
			display: flex;
			flex-direction: column;
			gap: 10px;
		}

		h1 {
			font-size: 1.5rem;
			margin: 0 0 20px 0;
		}

		input[type="text"],
		input[type="password"],
		input[type="submit"] {
			width: 100%;
			padding: 10px;
			margin: 0;
			border: 0;
			border-radius: 4px;
		}

		input[type="text"],
		input[type="password"] {
			background-color: var(--textbox-color);
			color: var(--font-color);
		}

		input[type="submit"] {
			background-color: var(--button-color);
			color: var(--button-text-color);
			margin: 10px 0;
		}

		input[type="submit"]:hover {
			background-color: var(--button-hover-color);
			cursor: pointer;
		}
	</style>
</head>
<body>
	<div id="main">
		<div class="content">
			<form action="" method="post">
				<h1>Registration</h1>

				<input type="text" name="username" placeholder="Username">
				<input type="password" name="password1" placeholder="Password">
				<input type="password" name="password2" placeholder="Confirm Password">

				<input id="btn-register" type="submit" name="register" value="Submit">

				<?php if ($submitted): ?>
					<?php if ($error !== false): ?>
						<div class="error-notice">
							<?= $error ?>
						</div>
					<?php else: ?>
						<div class="success-notice">
							Account created successfully.
						</div>
					<?php endif; ?>
				<?php endif; ?>
			</form>
		</div>
	</div>
</body>
</html>
