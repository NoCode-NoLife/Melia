<?php

namespace App\Http\Controllers\Auth;

use App\Http\Controllers\Controller;
use App\Models\User;
use App\Models\Account;
use App\Providers\RouteServiceProvider;
use Illuminate\Auth\Events\Registered;
use Illuminate\Http\RedirectResponse;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Validator;
use Illuminate\Validation\Rules;
use Illuminate\Validation\ValidationException;
use Inertia\Inertia;
use Inertia\Response;

class RegisteredUserController extends Controller
{
    /**
     * Display the registration view.
     */
    public function create(): Response
    {
        return Inertia::render('Register');
    }

    /**
     * Handle an incoming registration request.
     *
     * @throws \Illuminate\Validation\ValidationException
     */
    public function store(Request $request): RedirectResponse
    {
        $request->validate([
            'login' => 'required|string|min:3|max:255',
            'email' => 'required|string|email|min:4|max:255|unique:'.User::class,
            'password' => ['required', 'confirmed', Rules\Password::defaults()],
        ]);

        $validator = Validator::make(['login' => $request->login], [
            'login' => ['required', 'regex:/^[A-Za-z0-9]+$/'],
        ]);

        if ($validator->fails()) {
            throw ValidationException::withMessages([
            'login' => trans('auth.login.failed'),
            ]);
        }

        if (Account::where('name', $request->login)->exists()) {
            throw ValidationException::withMessages([
            'login' => trans('auth.login.exists'),
            ]);
        }

        $hashedPass = bcrypt(strtoupper(md5($request->password)));

        if (substr($hashedPass, 0, 4) == '$2y$') {
            $hashedPass = '$2a$' . substr($hashedPass, 4);
        }

        $account = Account::create([
            'name' => $request->login,
            'password' => $hashedPass,
            'settings' => '',
        ]);

        $user = User::create([
            'email' => $request->email,
            'account_id' => $account->accountId
        ]);

        event(new Registered($user));

        Auth::login($user);

        return redirect(RouteServiceProvider::HOME);
    }
}
