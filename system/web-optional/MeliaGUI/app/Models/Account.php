<?php

namespace App\Models;

// use Illuminate\Contracts\Auth\MustVerifyEmail;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Account extends Model
{
    use HasFactory;

    public $timestamps = false;

    protected $table = 'accounts';

    /**
     * The attributes that are mass assignable.
     *
     * @var array<int, string>
     */
    protected $fillable = [
        'accountId',
        'name',
        'password',
        'teamName',
        'authority',
        'settings',
        'medals',
        'giftMedals',
        'premiumMedals',
        'addicionalSlotCount',
        'teamEXP',
        'barracksThema',
        'selectedSlot',
        'loginState',
        'loginCharacter',
    ];
}
