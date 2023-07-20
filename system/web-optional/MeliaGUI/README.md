## About Melia GUI Host Application

This is the webapp that communicates with the Melia's servers.

To be able to run it you need to:

- Have PHP installed
- Run 'composer install'
- Make sure that you already run the melia servers once (to create the databases)
- Run 'php artisan migrate'
- Run 'npm install'
- Run 'npm run dev' (or production)

Configuration:

- Backups:
    (Windows) Make sure to have mysql installed and added to system variables. (https://github.com/spatie/laravel-backup/issues/289)
    On the Console/Kernel.php file choose when the backups will be schedule:
    `$schedule->command('backup:run')->daily()->at('00:00');`
    On the config/backup.php choose how much days the backups will be keep:
    `'keep_all_backups_for_days' => 7,`
    Documentation:
    https://spatie.be/docs/laravel-backup/v8/sending-notifications/overview
