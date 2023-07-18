<?php

namespace App\Http\Controllers;

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
        $onlineAccounts = Account::where('loginState', 1)
                                    ->orWhere('loginState', 2)
                                    ->get()
                                    ->count();

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

        return Inertia::render('AdminDashboard', [
            'account' => auth()->user()->account,
            'totalAccounts' => $totalAccounts,
            'onlineAccounts' => $onlineAccounts,
            'lastAccounts' => $lastAccounts,
        ]);
    }

    public function serverInfo()
    {
        $response = $this->client->request('GET', '/dashboard/server/info' );
        $statusCode = $response->getStatusCode();
        $body = $response->getBody()->getContents();

        $serverInfo = null;

        if ($statusCode == 200) {
            $serverInfo = json_decode($body);
        }

        return Inertia::render('AdminDashboard', [
            'account' => auth()->user()->account,
            'serverInfo' => $serverInfo
        ]);
    }
}
