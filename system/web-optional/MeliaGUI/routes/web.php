<?php

use App\Http\Controllers\ProfileController;
use App\Http\Controllers\AdminDashboardController;
use App\Http\Controllers\ConfigsController;
use App\Http\Controllers\BackupController;
use Illuminate\Foundation\Application;
use Illuminate\Support\Facades\Route;
use Inertia\Inertia;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return Inertia::render('Welcome', [
        'canLogin' => Route::has('login'),
        'canRegister' => Route::has('register'),
        'laravelVersion' => Application::VERSION,
        'phpVersion' => PHP_VERSION,
    ]);
})->name('home');

Route::get('/dashboard', function () {
    return Inertia::render('Dashboard', [
        'account' => auth()->user()->account,
    ]);
})->middleware(['auth', 'verified'])->name('dashboard');

Route::middleware(['auth', 'verified', 'authority:99'])->group(function () {
    Route::get('/admin/dashboard', [AdminDashboardController::class, 'get'])
        ->name('admin.dashboard');

    Route::get('/admin/configs', [ConfigsController::class, 'get'])
        ->name('admin.configs');

    Route::post('/admin/configs', [ConfigsController::class, 'store'])
        ->name('admin.configs.update');

    Route::post('/admin/kick/all', [AdminDashboardController::class, 'kickAll'])
        ->name('admin.kick.all.players');

    Route::post('/admin/message/broadcast', [AdminDashboardController::class, 'broadcastMessage'])
        ->name('admin.message.broadcast');

    Route::post('/admin/backup', [BackupController::class, 'create'])
        ->name('admin.backup.create');

    Route::post('/admin/backup/restore', [BackupController::class, 'restore'])
        ->name('admin.backup.restore');

    Route::post('/admin/backup/delete', [BackupController::class, 'delete'])
        ->name('admin.backup.delete');

    Route::post('/admin/close/zone/process', [AdminDashboardController::class, 'closeZoneProcess'])
        ->name('admin.close.zone.server.process');

    Route::post('/admin/create/zone', [AdminDashboardController::class, 'createNewZone'])
        ->name('admin.create.zone.server');
});

Route::middleware('auth')->group(function () {
    Route::get('/profile', [ProfileController::class, 'edit'])->name('profile.edit');
    Route::patch('/profile', [ProfileController::class, 'update'])->name('profile.update');
});

require __DIR__.'/auth.php';
