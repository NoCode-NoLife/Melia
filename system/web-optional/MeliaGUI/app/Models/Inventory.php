<?php

namespace App\Models;

// use Illuminate\Contracts\Auth\MustVerifyEmail;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use App\Models\Character;
use App\Models\Item;

class Inventory extends Model
{
    use HasFactory;

    public $timestamps = false;

    protected $primaryKey = 'characterId';
    protected $table = 'inventory';

    /**
     * The attributes that are mass assignable.
     *
     * @var array<int, string>
     */
    protected $fillable = [
        'characterId',
        'itemId',
        'sort',
        'equipSlot',
    ];

    public function item()
    {
        return $this->belongsTo(Item::class, 'itemId', 'itemUniqueId');
    }

    public function character()
    {
        return $this->belongsTo(Character::class, 'characterId');
    }
}
