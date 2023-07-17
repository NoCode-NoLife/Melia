<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Inertia\Inertia;
use App\Models\Account;

class AdminDashboardController extends Controller
{
    public function get(Request $request)
    {
        $totalAccounts = Account::all()->count();
        $onlineAccounts = Account::where('loginState', 1)->get()->count();

        return Inertia::render('AdminDashboard', [
            'account' => auth()->user()->account,
            'totalAccounts' => $totalAccounts,
            'onlineAccounts' => $onlineAccounts,
        ]);
    }
}
