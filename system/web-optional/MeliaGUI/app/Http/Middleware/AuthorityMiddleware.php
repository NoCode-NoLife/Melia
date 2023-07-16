<?php

namespace App\Http\Middleware;

use Closure;
use Illuminate\Http\Request;
use Symfony\Component\HttpFoundation\Response;

class AuthorityMiddleware
{
    /**
     * Handle an incoming request.
     *
     * @param  \Closure(\Illuminate\Http\Request): (\Symfony\Component\HttpFoundation\Response)  $next
     */
    public function handle(Request $request, Closure $next, $requiredLevel): Response
    {
        if (!$request->expectsJson()) {
            redirect('home');
        }

        if (auth()->user()->account->authority >= $requiredLevel) {
            abort(403);
        }

        return $next($request);
    }
}
