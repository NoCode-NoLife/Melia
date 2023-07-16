<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Hash;
use App\Models\User;
use App\Models\Account;

class UserController extends Controller
{
    public function register(Request $request)
    {
        $request->validate([
            'name' => 'required|string|min:3',
            'password' => 'required|min:8',
            'teamName' => 'required|string|min:3',
            'email' => 'required|email|unique:users',
        ]);

        $account = Account::create([
            'name' => $request->name,
            'password' => Hash::make($request->password),
            'teamName' => $request->teamName,
            'settings' => '',
        ]);

        $user = User::create([
            'email' => $request->email,
            'account_id' => $account->id
        ]);

        $token = $user->createToken('auth_token')->plainTextToken;

        return response()->json(['user' => $user,'token' => $token], 201);
    }
}
