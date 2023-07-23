<?php

namespace App\Models;

// use Illuminate\Contracts\Auth\MustVerifyEmail;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use App\Models\User;
use App\Models\Character;

class Account extends Model
{
    use HasFactory;

    public $timestamps = false;

    protected $primaryKey = 'accountId';
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

        /**
     * The attributes that should be hidden for serialization.
     *
     * @var array<int, string>
     */
    protected $hidden = [
        'password',
    ];

    public function user()
    {
        return $this->hasOne(User::class, 'account_id');
    }

    public function characters()
    {
        return $this->hasMany(Character::class, 'accountId');
    }
}
