<?php

namespace App\Http\Controllers;

use App\Services\GuzzleClientService;
use Illuminate\Validation\ValidationException;
use Illuminate\Support\Facades\File;
use Illuminate\Http\Request;
use Carbon\Carbon;
use SplFileInfo;

class BackupController extends Controller
{
    private $guzzleClientService;

    public function __construct(GuzzleClientService $guzzleClientService)
    {
        $this->guzzleClientService = $guzzleClientService;
    }

    public function create(Request $request)
    {
        $fileName = str_replace(':', '-', str_replace(' ', '_', Carbon::now()->toDateTimeString())) . '.sql';
        $path = storage_path('app\\db_backup\\' . $fileName);
        $serverName = config('database.connections.mysql.host');
        $serverPort = config('database.connections.mysql.port');
        $username = config('database.connections.mysql.username');
        $password = config('database.connections.mysql.password');
        $databaseName = config('database.connections.mysql.database');

        $cmd = "mysqldump --default-character-set=utf8 --protocol=tcp --single-transaction=TRUE --skip-triggers  --user={$username} --password={$password} --host={$serverName} --port={$serverPort} {$databaseName} > {$path}";
        exec($cmd);

        return back()->with('status', [ 'type' => 'success', 'message' => trans('validation.backup.successful') ]);
    }

    public function delete(Request $request)
    {
        $request->validate([
            'backupDate' => 'required',
        ]);

        $directory = storage_path('app\\' . 'db_backup');
        $files = File::files($directory);

        try {
            $backupDate = new Carbon($request->backupDate);
        } catch(\Exception) {
            throw ValidationException::withMessages([
                'status' => [ 'type' => 'success', 'message' => trans('validation.backup.delete.fail')],
            ]);
        }

        foreach ($files as $file) {
            $dateStr = str_replace('.sql', '', str_replace('-', ':', str_replace('_', ' ', basename($file))));
            $date = new Carbon($dateStr);
            if ($backupDate->eq($date)) {
                File::delete((new SplFileInfo($file))->getPathname());
            }
        }

        return back()->with('status', [ 'type' => 'warning', 'message' => trans('validation.backup.delete.successful') ]);
    }

    public function restore(Request $request)
    {
        $request->validate([
            'backupDate' => 'required',
        ]);

        $isServerOnline = false;

        try {
            $response = $this->guzzleClientService->client->request('GET', '/api/info/server' );
            $statusCode = $response->getStatusCode();
            if ($statusCode == 200) {
                $isServerOnline = true;
            }
        } catch (\Exception $e) {
        }

        if ($isServerOnline) {
            throw ValidationException::withMessages([
                'status' => [ 'type' => 'danger', 'message' => trans('validation.backup.restore.cant') ],
            ]);
        }

        $directory = storage_path('app\\' . 'db_backup');
        $files = File::files($directory);

        try {
            $backupDate = new Carbon($request->backupDate);
        } catch(\Exception) {
            throw ValidationException::withMessages([
                'status' => [ 'type' => 'success', 'message' => trans('validation.backup.delete.fail')],
            ]);
        }

        foreach ($files as $file) {
            $dateStr = str_replace('.sql', '', str_replace('-', ':', str_replace('_', ' ', basename($file))));
            $date = new Carbon($dateStr);
            if ($backupDate->eq($date)) {
                $filePath = (new SplFileInfo($file))->getPathname();
            }
        }

        if (!$filePath) {
            throw ValidationException::withMessages([
                'status' => [ 'type' => 'success', 'message' => trans('validation.backup.restore.fail') ],
            ]);
        }

        $serverName = env('DB_HOST', 'localhost');
        $serverPort = env('DB_PORT', 3306);
        $username = env('DB_USERNAME', 'root');
        $password = env('DB_PASSWORD', '');
        $databaseName = env('DB_DATABASE', 'melia');

        $cmd = "mysql --host={$serverName} --user={$username} --port={$serverPort} --password={$password} {$databaseName} < $filePath";
        exec($cmd);

        return back()->with('status', [ 'type' => 'success', 'message' => trans('validation.backup.restore.successful') ]);
    }
}
