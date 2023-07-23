<?php

namespace App\Console;

use Illuminate\Console\Scheduling\Schedule;
use Illuminate\Foundation\Console\Kernel as ConsoleKernel;
use Carbon\Carbon;

class Kernel extends ConsoleKernel
{
    /**
     * Define the application's command schedule.
     */
    protected function schedule(Schedule $schedule): void
    {
        $schedule = config('backup.schedule');

        if ($schedule == 2) {
            $schedule->call(function () {
                $this->createBackup();
            })->daily();
        } elseif ($schedule == 3) {
            $schedule->call(function () {
                $this->createBackup();
            })->weekly();
        } elseif ($schedule == 4) {
            $schedule->call(function () {
                $this->createBackup();
            })->monthly();
        }
    }

    /**
     * Register the commands for the application.
     */
    protected function commands(): void
    {
        $this->load(__DIR__.'/Commands');

        require base_path('routes/console.php');
    }

    private function createBackup()
    {
        $fileName = str_replace(':', '-', str_replace(' ', '_', Carbon::now()->toDateTimeString())) . '.sql';
        $path = storage_path('app\\' . env('APP_NAME', 'Melia') .'\\' . $fileName);
        $serverName = env('DB_HOST', 'localhost');
        $serverPort = env('DB_PORT', 3306);
        $username = env('DB_USERNAME', 'root');
        $password = env('DB_PASSWORD', '');
        $databaseName = env('DB_DATABASE', 'melia');

        $cmd = "mysqldump --default-character-set=utf8 --protocol=tcp --single-transaction=TRUE --skip-triggers  --user={$username} --password={$password} --host={$serverName} --port={$serverPort} {$databaseName} > {$path}";
        exec($cmd);
    }
}
