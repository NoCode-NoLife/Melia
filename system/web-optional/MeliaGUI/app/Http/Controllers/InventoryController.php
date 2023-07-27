<?php

namespace App\Http\Controllers;

use Illuminate\Support\Facades\Storage;
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

    public function removeItem(Request $request)
    {
        $request->validate([
            'itemUniqueId' => 'required|integer',
            'amount' => 'required|integer',
        ]);

        try {
            $resPlayerCount = $this->client->post('/api/remove/item', [
                'json' => [
                        'itemUniqueId' => $request->itemUniqueId,
                        'amount' => $request->amount
                    ]
                ]
            );

            $statusCodePlayerCount = $resPlayerCount->getStatusCode();

            if ($statusCodePlayerCount == 200) {
                return back()->with('status', [ 'type' => 'success', 'message' => trans('validation.remove.item.successful') ]);
            }
        } catch (\Exception $e) {
        }

        return back()
                ->withInput()
                ->with('status', [ 'type' => 'danger', 'message' => trans('validation.remove.item.failed') ]);
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
                            'itemUniqueId' => $inventory->item->itemUniqueId,
                            'characterName' => $character->name,
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
