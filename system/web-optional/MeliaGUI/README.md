## About Melia GUI Host Application

This is the webapp that communicates with the Melia's servers.

To be able to run it you need to:

- Make sure that you already run the melia servers once (to create the databases) and download PHP
- Otherwise install PHP (v8.2.7+) and composer by yourself then enable the follow extentions:
  - fileinfo
  - zip
  - mysqli
  - pdo_mysql
- Navigate to the /melia/system/web-optional/MeliaGUI/ and then
  - Run 'composer install'
  - Run 'php artisan migrate'
  - Run 'npm install'
  - Run 'npm run dev'
- Rename the .env.example and fill with the correct values on it (like database credentials, etc...)
- Copy the contents of the file /user/keys/api_key (youy must ran the server once) and place on the MELIA_API_KEY .env file
  - RUN 'php artisan serve'
- If you plan to use the backup feature configure the .env
  - Install mysql properly
  - DB_MYSQL_DUMP_PATH='path/to/mysql_dump/folder/'
- If you want to see the administration dasboard set the authority value of the account to 99
