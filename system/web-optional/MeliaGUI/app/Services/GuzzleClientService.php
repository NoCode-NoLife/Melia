<?php

namespace App\Services;

use GuzzleHttp\Client;

class GuzzleClientService
{
    public $client;

    public function __construct()
    {
        $this->client = new Client([
            'base_uri' => config('webserver.host') . ":" . config('webserver.port'),
        ]);
    }
}
