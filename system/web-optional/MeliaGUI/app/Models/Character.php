<?php

namespace App\Models;

// use Illuminate\Contracts\Auth\MustVerifyEmail;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use App\Models\Account;
use App\Models\Inventory;
use App\Models\Job;

class Character extends Model
{
    use HasFactory;

    public $timestamps = false;

    protected $primaryKey = 'characterId';
    protected $table = 'characters';

    /**
     * The attributes that are mass assignable.
     *
     * @var array<int, string>
     */
    protected $fillable = [
        'characterId',
        'accountId',
        'name',
        'teamName',
        'job',
        'gender',
        'hair',
        'level',
        'slot',
        'barrackLayer',
        'bx',
        'by',
        'bz',
        'bd',
        'x',
        'y',
        'z',
        'exp',
        'maxEXP',
        'totalExp',
        'hp',
        'hpRate',
        'sp',
        'spRate',
        'maxSp',
        'stamina',
        'staminaByJob',
        'maxStamina',
        'str',
        'strByJob',
        'con',
        'conByJob',
        'int',
        'intByJob',
        'spr',
        'sprByJob',
        'dex',
        'dexByJob',
        'statByBonus',
        'usedStat',
        'abilityBonus',
        'usedStat',
        'abilityPoints',
        'silver',
        'equipVisibility',
    ];

    public function account()
    {
        return $this->belongsTo(Account::class, 'accountId');
    }

    public function inventories()
    {
        return $this->hasMany(Inventory::class, 'characterId');
    }

    public function jobs()
    {
        return $this->hasMany(Job::class, 'characterId');
    }
}
