<?php

use App\Http\Controllers\ProfileController;
use App\Http\Controllers\AdminDashboardController;
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
});

Route::get('/dashboard', function () {
    return Inertia::render('Dashboard', [
        'account' => auth()->user()->account,
    ]);
})->middleware(['auth', 'verified'])->name('dashboard');

Route::get('/admin/dashboard', [AdminDashboardController::class, 'get'])
    ->middleware(['auth', 'verified', 'authority:99'])
    ->name('admin.dashboard');

Route::post('/admin/kick/all', [AdminDashboardController::class, 'kickAll'])
    ->middleware(['auth', 'verified', 'authority:99'])
    ->name('admin.kick.all.players');

Route::post('/admin/backup', [BackupController::class, 'create'])
    ->middleware(['auth', 'verified', 'authority:99'])
    ->name('admin.backup.create');

Route::post('/admin/backup/restore', [BackupController::class, 'restore'])
    ->middleware(['auth', 'verified', 'authority:99'])
    ->name('admin.backup.restore');

Route::post('/admin/backup/delete', [BackupController::class, 'delete'])
    ->middleware(['auth', 'verified', 'authority:99'])
    ->name('admin.backup.delete');

Route::middleware('auth')->group(function () {
    Route::get('/profile', [ProfileController::class, 'edit'])->name('profile.edit');
    Route::patch('/profile', [ProfileController::class, 'update'])->name('profile.update');
});

require __DIR__.'/auth.php';
