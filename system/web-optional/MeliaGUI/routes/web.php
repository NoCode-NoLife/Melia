<?php

use App\Http\Controllers\ProfileController;
use App\Http\Controllers\AdminDashboardController;
use App\Http\Controllers\ConfigsController;
use App\Http\Controllers\BackupController;
use App\Http\Controllers\InventoryController;
use Illuminate\Support\Facades\Route;

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
    return redirect(route('login'));
})->name('home');

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

    Route::get('/admin/inventory/manager', [InventoryController::class, 'get'])
        ->name('admin.inventory.manager');

    Route::post('/admin/inventory/manager', [InventoryController::class, 'search'])
        ->name('admin.inventory.manager.search');

    Route::post('/admin/inventory/remove/item', [InventoryController::class, 'removeItem'])
        ->name('admin.inventory.manager.remove.item');
});

Route::middleware('auth', 'verified')->group(function () {
    Route::get('/profile', [ProfileController::class, 'edit'])->name('profile.edit');
    Route::patch('/profile', [ProfileController::class, 'update'])->name('profile.update');
});

require __DIR__.'/auth.php';
