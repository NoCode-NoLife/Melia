<?php

namespace App\Providers;

use Illuminate\Support\ServiceProvider;
use App\Services\GuzzleClientService;

class AppServiceProvider extends ServiceProvider
{
    /**
     * Register any application services.
     */
    public function register(): void
    {
        $this->app->singleton(GuzzleClientService::class, function ($app) {
            return new GuzzleClientService();
        });
    }

    /**
     * Bootstrap any application services.
     */
    public function boot(): void
    {
        //
    }
}
