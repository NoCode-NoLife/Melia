<?php

namespace App\Http\Controllers;

use Spatie\Backup\Tasks\Monitor\BackupDestinationStatusFactory;
use Illuminate\Http\Request;
use Inertia\Inertia;
use App\Models\Account;
use App\Models\Character;
use GuzzleHttp\Client;

class AdminDashboardController extends Controller
{
    private $client;

    public function __construct()
    {
        $this->client = new Client([
            'base_uri' => config('webserver.host') . ":" . config('webserver.port'),
        ]);
    }

    public function get(Request $request)
    {
        $totalAccounts = Account::all()->count();
        $lastAccounts = Account::query()
                        ->orderByDesc('accountId')
                        ->limit(20)
                        ->get();

        $lastAccounts->each(function ($account) {
            $account['created_at'] = $account->user ? $account->user->created_at : now();
            $characters = Character::where('accountId', $account->accountId)
                                    ->get();

            $highestCharacterLevel = 0;
            $highestCharacterName = '';

            foreach ($characters as $character) {
                if ($character->level > $highestCharacterLevel) {
                    $highestCharacterLevel = $character->level;
                    $highestCharacterName = $character->name;
                }
            }

            $account['characters'] = $characters->count();
            $account['highestCharacterLevel'] = $highestCharacterLevel;
            $account['highestCharacterName'] = $highestCharacterName;
        });

        $isServerOnline = true;
        $processes = [];
        $totalCpuUsage = 0;

        try {
            $resProcesses = $this->client->request('GET', '/api/info/processes' );
            $statusCodeProcesses = $resProcesses->getStatusCode();
            $bodyProcesses = $resProcesses->getBody()->getContents();

            if ($statusCodeProcesses == 200) {
                $processesInternal = json_decode($bodyProcesses);

                foreach ($processesInternal as $process) {
                    $ramUsage = ($process->ProcessRamUsage / $process->TotalRAM) * 100;
                    $processInternal['ProcessId'] = $process->ProcessId;
                    $processInternal['ProcessName'] = $process->ProcessName;
                    $processInternal['CpuUsage'] = number_format($process->CpuUsagePercentage, 2);
                    $processInternal['RamUsage'] = number_format($ramUsage, 2);
                    $processInternal['ServerIp'] = $process->ServerIp;
                    $totalCpuUsage += number_format($process->CpuUsagePercentage);
                    $processes[] = $processInternal;
                }
            }
        } catch (\Exception $e) {
            $isServerOnline = false;
        }

        $onlineAccounts = 0;

        try {
            $resPlayerCount = $this->client->request('GET', '/api/info/playercount' );
            $statusCodePlayerCount = $resPlayerCount->getStatusCode();
            $bodyPlayerCount = $resPlayerCount->getBody()->getContents();

            if ($statusCodePlayerCount == 200) {
                $playerCountJson = json_decode($bodyPlayerCount);
                $onlineAccounts = $playerCountJson->playerCount;
            }
        } catch (\Exception $e) {
            $isServerOnline = false;
        }

        return Inertia::render('AdminDashboard', [
            'account' => auth()->user()->account,
            'totalAccounts' => $totalAccounts,
            'onlineAccounts' => $onlineAccounts,
            'lastAccounts' => $lastAccounts,
            'processes' => $processes,
            'totalCpuUsage' => $totalCpuUsage,
            'isServerOnline' => $isServerOnline,
            'backups' => $this->getBackups(),
        ]);
    }

    public function kickAll(Request $request)
    {
        try {
            $response = $this->client->request('POST', '/api/kick/all' );
            $statusCode = $response->getStatusCode();
            $body = $response->getBody()->getContents();

            if ($statusCode == 200) {
                $decodedBody = json_decode($body);
                response()->json(['status' => $decodedBody['status']]);
            }
        } catch (\Exception $e) {
        }

        response()->json(['status' => 'Fail to kick all players.']);
    }

    private function getBackups()
    {
        $statuses = BackupDestinationStatusFactory::createForMonitorConfig(config('backup.monitor_backups'));
        $info = [];

        foreach ($statuses as $status) {
            $backups = $status->backupDestination()->backups();
            foreach($backups as $backup) {
                $info[] = [
                    'date' => $backup->date()->format('Y-m-d H:i:s'),
                    'sizeInBytes' => $this->formatBytes($backup->sizeInBytes()),
                    'path' => $backup->path(),
                ];
            }
        }

        return $info;
    }

    private function formatBytes($size, $precision = 2)
    {
        $base = log($size, 1024);
        $suffixes = array('', 'Kb', 'Mb', 'Gb', 'Tb');

        return round(pow(1024, $base - floor($base)), $precision) .' '. $suffixes[floor($base)];
    }
}
