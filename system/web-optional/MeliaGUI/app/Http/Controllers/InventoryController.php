<?php

namespace App\Http\Controllers;

use Illuminate\Support\Facades\File;
use Illuminate\Support\Facades\Storage;
use Illuminate\Validation\ValidationException;
use Illuminate\Http\Request;
use GuzzleHttp\Client;
use Inertia\Inertia;
use App\Models\Account;

class InventoryController extends Controller
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
        $isServerOnline = false;

        try {
            $resPlayerCount = $this->client->request('GET', '/api/info/server' );
            $statusCodePlayerCount = $resPlayerCount->getStatusCode();

            if ($statusCodePlayerCount == 200) {
                $isServerOnline = true;
            }
        } catch (\Exception $e) {
            $isServerOnline = false;
        }

        $items = [];

        return Inertia::render('InventoryView', [
            'account' => auth()->user()->account,
            'isServerOnline' => $isServerOnline,
            'items' => $items,
            'status' => session('status'),
        ]);
    }

    public function search(Request $request)
    {
        $request->validate([
            'teamName' => 'required|string',
        ]);

        $isServerOnline = false;

        try {
            $resPlayerCount = $this->client->request('GET', '/api/info/server' );
            $statusCodePlayerCount = $resPlayerCount->getStatusCode();

            if ($statusCodePlayerCount == 200) {
                $isServerOnline = true;
            }
        } catch (\Exception $e) {
            $isServerOnline = false;
        }

        $accounts = Account::where('teamName', 'LIKE', '%' . $request->teamName . '%')->get();

        $items = [];

        $itemsDb = Storage::json('db\items.json');

        if ($itemsDb != null) {
            foreach($accounts as $account) {
                foreach ($account->characters as $character) {
                    foreach ($character->inventories as $inventory) {
                        $items[$account->teamName][$character->name][] =  [
                            'itemName' => $this->getItemName($itemsDb, $inventory->item->itemId),
                            'itemId' => $inventory->item->itemId,
                            'amount' => $inventory->item->amount,
                        ];
                    }
                }
            }
        }

        return Inertia::render('InventoryView', [
            'account' => auth()->user()->account,
            'isServerOnline' => $isServerOnline,
            'items' => $items,
            'status' => session('status'),
        ]);
    }

    private function getItemName($itemDb, $classId)
    {
        foreach($itemDb as $item) {
            if ($item['itemId'] == $classId) {
                return $item['name'];
            }
        }
    }
}
