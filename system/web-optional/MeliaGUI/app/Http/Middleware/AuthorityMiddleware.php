<?php

namespace App\Http\Middleware;

use Closure;
use Illuminate\Http\Request;
use Symfony\Component\HttpFoundation\Response;
use App\Providers\RouteServiceProvider;

class AuthorityMiddleware
{
    /**
     * Handle an incoming request.
     *
     * @param  \Closure(\Illuminate\Http\Request): (\Symfony\Component\HttpFoundation\Response)  $next
     */
    public function handle(Request $request, Closure $next, $requiredLevel): Response
    {
        if (!auth()->user() || auth()->user()->account->authority < $requiredLevel) {
            return redirect(RouteServiceProvider::HOME);
        }

        return $next($request);
    }
}
