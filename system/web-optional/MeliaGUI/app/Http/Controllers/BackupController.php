<?php

namespace App\Http\Controllers;

use FFI\Exception;
use Spatie\Backup\Tasks\Monitor\BackupDestinationStatusFactory;
use Illuminate\Validation\ValidationException;
use Spatie\Backup\Tasks\Backup\BackupJobFactory;
use Illuminate\Http\Request;
use Carbon\Carbon;

class BackupController extends Controller
{
    public function create(Request $request)
    {
        \Spatie\DbDumper\Databases\MySql::create()
                ->setDumpBinaryPath('H:/Program Files/MySQL/MySQL Server 8.1/bin')
                ->setDbName(env('DB_DATABASE'))
                ->setUserName(env('DB_USERNAME'))
                ->setPassword(env('DB_PASSWORD'))
                ->setHost(env('DB_HOST'))
                ->dumpToFile('H:/Repositories/Github/melia/dump.sql');

        dd(function_exists('shell_exec'));

        return;

        $backupJob = BackupJobFactory::createFromArray([
            'backup' => [
                'name' => config('backup.backup.name'),
                'source' => [
                    'files' => config('backup.backup.source.files'),
                    'databases' => config('backup.backup.source.databases')
                ],
                'destination' => [
                    'disks' => config('backup.backup.destination.disks'),
                ],
            ]

        ]);

        $backupJob->disableSignals();
        $backupJob->disableNotifications();
        $backupJob->run();

        return response()->redirectTo(route('admin.dashboard'));
    }

    public function delete(Request $request)
    {
        $request->validate([
            'backupDate' => 'required|date',
        ]);

        $statuses = BackupDestinationStatusFactory::createForMonitorConfig(config('backup.monitor_backups'));

        try {
            $backupDate = Carbon::createFromFormat('m/d/Y H:i:s', $request->backupDate);
        } catch(Exception) {
            throw ValidationException::withMessages([
                'backup' => trans('backup.delete.fail')
            ]);
        }

        foreach ($statuses as $status) {
            $backups = $status->backupDestination()->backups();
            foreach($backups as $backup) {
                $date = Carbon::createFromFormat('m/d/Y H:i:s', $backup->date()->format('Y-m-d H:i:s'));
                if ($date->eq($backupDate)) {
                    $backup->delete();
                }
            }
        }

        return response()->redirectTo(route('admin.dashboard'));
    }

    public function restore(Request $request)
    {
        $request->validate([
            'backupDate' => 'required|date',
        ]);

        $statuses = BackupDestinationStatusFactory::createForMonitorConfig(config('backup.monitor_backups'));

        try {
            $backupDate = Carbon::createFromFormat('m/d/Y H:i:s', $request->backupDate);
        } catch(Exception) {
            throw ValidationException::withMessages([
                'backup' => trans('backup.delete.fail')
            ]);
        }

        foreach ($statuses as $status) {
            $backups = $status->backupDestination()->backups();
            foreach($backups as $backup) {
                $date = Carbon::createFromFormat('m/d/Y H:i:s', $backup->date()->format('Y-m-d H:i:s'));
                if ($date->eq($backupDate)) {
                    $backup->restore();
                }
            }
        }

        return response()->redirectTo(route('admin.dashboard'));
    }
}


