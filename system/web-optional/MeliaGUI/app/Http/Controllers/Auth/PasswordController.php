<?php

namespace App\Http\Controllers\Auth;

use App\Http\Controllers\Controller;
use Illuminate\Http\RedirectResponse;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Hash;
use Illuminate\Validation\Rules\Password;

class PasswordController extends Controller
{
    /**
     * Update the user's password.
     */
    public function update(Request $request): RedirectResponse
    {
        $validated = $request->validate([
            'current_password' => ['required', 'current_password'],
            'password' => ['required', Password::defaults(), 'confirmed'],
        ]);

        $hashedPass = bcrypt(strtoupper(md5($validated['password'])));

        if (substr($hashedPass, 0, 4) == '$2y$') {
            $hashedPass = '$2a$' . substr($hashedPass, 4);
        }

        $request->user()->update([
            'password' => $hashedPass,
        ]);

        return back();
    }
}
