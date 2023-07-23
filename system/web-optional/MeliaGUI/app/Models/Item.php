<?php

namespace App\Models;

// use Illuminate\Contracts\Auth\MustVerifyEmail;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use App\Models\Inventory;

class Item extends Model
{
    use HasFactory;

    public $timestamps = false;

    protected $primaryKey = 'itemUniqueId';
    protected $table = 'items';

    /**
     * The attributes that are mass assignable.
     *
     * @var array<int, string>
     */
    protected $fillable = [
        'itemUniqueId',
        'itemId',
        'amount',
    ];

    public function inventories()
    {
        return $this->hasMany(Inventory::class, 'itemUniqueId', 'itemId');
    }
}
