<?php

namespace App\Http\Controllers\Auth;

use App\Http\Controllers\Controller;
use Illuminate\Http\RedirectResponse;
use Illuminate\Http\Request;
use Illuminate\Validation\ValidationException;

class PasswordController extends Controller
{
    /**
     * Update the user's password.
     */
    public function update(Request $request): RedirectResponse
    {
        $request->validate([
            'current_password' => ['required'],
            'password' => ['required'],
            'password_confirmation' => ['required'],
        ]);

        if ($request->password !== $request->password_confirmation) {
            throw ValidationException::withMessages([
                'password_confirmation' => trans('auth.incorrect.password.confirmation'),
            ]);
        }

        if (!password_verify(strtoupper(md5($request->current_password)), auth()->user()->account->password)) {
            throw ValidationException::withMessages([
                'current_password' => trans('auth.incorrect.password'),
            ]);
        }

        $hashedPass = bcrypt(strtoupper(md5($request->password)));

        if (substr($hashedPass, 0, 4) == '$2y$') {
            $hashedPass = '$2a$' . substr($hashedPass, 4);
        }

        $request->user()->account->update([
            'password' => $hashedPass,
        ]);

        return back();
    }
}
