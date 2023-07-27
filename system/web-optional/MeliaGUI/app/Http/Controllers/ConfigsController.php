<?php

namespace App\Http\Controllers;

use Illuminate\Http\RedirectResponse;
use Illuminate\Http\Request;
use Inertia\Response;
use Inertia\Inertia;
use GuzzleHttp\Client;

class ConfigsController extends Controller
{
    private $client;

    public function __construct()
    {
        $this->client = new Client([
            'base_uri' => config('webserver.host') . ":" . config('webserver.port'),
        ]);
    }

    /**
     * Display the current available configs.
     */
    public function get(Request $request): Response
    {
        $isServerOnline = true;

        $configs = null;

        try {
            $response = $this->client->request('GET', '/api/info/configs');
            $statusCode = $response->getStatusCode();
            $body = $response->getBody()->getContents();

            if ($statusCode == 200) {
                $configs = json_decode($body);
            }
        } catch (\Exception $e) {
            $isServerOnline = false;
        }

        return Inertia::render('ConfigsView', [
            'account' => auth()->user()->account,
            'backupSchedule' => config('backup.schedule'),
            'enableTrading' => true,
            'isServerOnline' => $isServerOnline,
            'configs' => $configs,
            'status' => session('status'),
        ]);
    }

    /**
     * Updates the configs.
     */
    public function store(Request $request): RedirectResponse
    {
        try {
            $response = $this->client->post('/api/info/configs', ['json' => $request->input()]);
            $statusCode = $response->getStatusCode();
            if ($statusCode == 200) {
                return back()
                    ->with('status', [ 'type' => 'success', 'message' => trans('validation.configs.successful.updated') ]);
            }
        } catch (\Exception $e) {
        }

        return back()->with('status', [ 'type' => 'danger', 'message' => trans('validation.configs.update.fail') ]);
    }
}
