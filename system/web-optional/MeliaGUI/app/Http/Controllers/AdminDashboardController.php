<?php

namespace App\Http\Controllers;

use Illuminate\Support\Facades\File;
use Illuminate\Http\Request;
use Inertia\Inertia;
use App\Models\Account;
use App\Models\Character;
use GuzzleHttp\Client;
use Carbon\Carbon;
use SplFileInfo;

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
            'status' => session('status'),
            'silverChartData' => $this->getSilverData()
        ]);
    }

    public function kickAll(Request $request)
    {
        try {
            $response = $this->client->request('POST', '/api/kick/all' );
            $statusCode = $response->getStatusCode();
            $body = $response->getBody()->getContents();

            if ($statusCode == 200) {
                return back()->with('status', [ 'type' => 'success', 'message' => trans('kick.all.players.successful') ]);
            }
        } catch (\Exception $e) {
        }

        return back()->with('status', [ 'type' => 'danger', 'message' => trans('kick.all.players.fail') ]);
    }

    public function broadcastMessage(Request $request) {
        $request->validate([
            'message' => 'required|string|min:3'
        ]);

        try {
            $response = $this->client->post('/api/message/broadcast', ['json' => ['message' => $request->message]] );
            $statusCode = $response->getStatusCode();
            $body = $response->getBody()->getContents();

            if ($statusCode == 200) {

                return back()->with('status', [ 'type' => 'success', 'message' => trans('message.broadcast.success') ]);
            }
        } catch (\Exception $e) {
        }

        return back()->with('status', [ 'type' => 'danger', 'message' => trans('message.broadcast.fail') ]);
    }

    private function getSilverData($maxCount = 10)
    {
        $accounts = Account::all();


        $silverAmounts = [];

        foreach ($accounts as $account) {
            foreach ($account->characters as $character) {
                foreach ($character->inventories as $inventory) {
                    if ($inventory->item->itemId == 900011) {
                        $teamName = $account->teamName;
                        $characterName = $character->name;
                        $silverAmount = $inventory->item->amount;
                        // Store the silver amount with the corresponding team name and character name
                        $silverAmounts[$teamName][$characterName] = $silverAmount;
                    }
                }
            }
        }

        // Calculate the total silver amount for each account and sort the $silverAmounts array in descending order
        $sortedAccounts = collect($silverAmounts)->map(function ($characterData, $teamName) {
            $totalSilver = array_sum($characterData);
            return ['teamName' => $teamName, 'totalSilver' => $totalSilver];
        })->sortByDesc('totalSilver')->take($maxCount);

        // Create the final result array with individual character entries for each account
        $topAccounts = [];

        foreach ($sortedAccounts as $account) {
            $teamName = $account['teamName'];
            $characterData = $silverAmounts[$teamName];
            $topAccounts[$teamName] = $characterData;
        }

        return $topAccounts;
    }

    private function getBackups($maxCount = 10)
    {
        $info = [];
        $count = 0;

        $directory = storage_path('app\\' . env('APP_NAME', 'Melia'));
        $files = File::files($directory);

        foreach ($files as $file) {
            $dateStr = str_replace('.sql', '', str_replace('-', ':', str_replace('_', ' ', basename($file))));
            $date = new Carbon($dateStr);
            $relativePath = str_replace(storage_path(), '',(new SplFileInfo($file))->getPathname());
            $info[] = [
                'date' => $date->format('Y-m-d H:i:s'),
                'sizeInBytes' => $this->formatBytes(filesize($file)),
                'path' => $relativePath,
            ];
        }

        usort($info, function($a, $b) {
            return strcmp($b['date'], $a['date']);
        });

        return array_slice($info, 0, $maxCount);
    }

    private function formatBytes($size, $precision = 2)
    {
        $base = log($size, 1024);
        $suffixes = array('', 'Kb', 'Mb', 'Gb', 'Tb');

        return round(pow(1024, $base - floor($base)), $precision) .' '. $suffixes[floor($base)];
    }
}
