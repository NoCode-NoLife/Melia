<?php

namespace App\Http\Controllers;

use App\Services\GuzzleClientService;
use Illuminate\Http\RedirectResponse;
use Illuminate\Http\Request;
use Inertia\Response;
use Inertia\Inertia;

class ConfigsController extends Controller
{
    private $guzzleClientService;

    public function __construct(GuzzleClientService $guzzleClientService)
    {
        $this->guzzleClientService = $guzzleClientService;
    }

    /**
     * Display the current available configs.
     */
    public function get(Request $request): Response
    {
        $isServerOnline = true;

        $configs = null;

        try {
            $response = $this->guzzleClientService->client->request('GET', '/api/info/configs');
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
            $response = $this->guzzleClientService->client->post('/api/info/configs', ['json' => $request->input()]);
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
