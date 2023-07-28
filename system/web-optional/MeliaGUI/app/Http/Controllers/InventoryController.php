<?php

namespace App\Http\Controllers;

use App\Services\GuzzleClientService;
use Illuminate\Support\Facades\Storage;
use Illuminate\Http\Request;
use Inertia\Inertia;
use App\Models\Account;
use App\Models\Inventory;
use App\Models\Character;
use App\Models\Item;

class InventoryController extends Controller
{
    private $guzzleClientService;

    public function __construct(GuzzleClientService $guzzleClientService)
    {
        $this->guzzleClientService = $guzzleClientService;
    }

    public function get(Request $request)
    {
        $isServerOnline = false;

        try {
            $response = $this->guzzleClientService->client->request('GET', '/api/info/server' );
            $statusCode = $response->getStatusCode();
            if ($statusCode == 200) {
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
            'characterId' => 'required|integer',
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

        $character = Character::find($request->characterId);

        $inventory = Inventory::where('itemId', $request->itemUniqueId)
                            ->first();

        if (!$character  || ($character->account->loginState == 2 && $isServerOnline) || !$inventory || $inventory->characterId != $character->characterId) {
            return back()
                ->withInput()
                ->with('status', [ 'type' => 'danger', 'message' => trans('validation.remove.item.failed') ]);
        }

        $item = $inventory->item;

        $newItemAmount = $item->amount - $request->amount;

        if ($newItemAmount < 0) {
            $newItemAmount = 0;
        }

        if ($newItemAmount == 0) {
            Inventory::where('itemId', $request->itemUniqueId)
                            ->where('characterId', $request->characterId)
                            ->delete();

            Item::where('itemUniqueId', $request->itemUniqueId)
                            ->delete();
        } else {
            $item->update([
                'amount' => $newItemAmount
            ]);
        }

        return back()
                ->withInput()
                ->with('status', [ 'type' => 'success', 'message' => trans('validation.remove.item.successful') ]);
    }

    public function search(Request $request)
    {
        $request->validate([
            'teamName' => 'required|string',
        ]);

        $isServerOnline = false;

        try {
            $response = $this->guzzleClientService->client->request('GET', '/api/info/server' );
            $statusCode = $response->getStatusCode();
            if ($statusCode == 200) {
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
                            'characterId' => $character->characterId,
                            'isCharacterOnline' => $character->account->loginState == 2
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
