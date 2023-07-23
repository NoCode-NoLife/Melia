<?php

namespace App\Models;

// use Illuminate\Contracts\Auth\MustVerifyEmail;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use App\Models\Character;

class Job extends Model
{
    use HasFactory;

    public $timestamps = false;

    protected $primaryKey = 'characterId';
    protected $table = 'jobs';

    /**
     * The attributes that are mass assignable.
     *
     * @var array<int, string>
     */
    protected $fillable = [
        'characterId',
        'jobId',
        'circle',
        'skillPoints',
        'totalExp'
    ];

    public function character()
    {
        return $this->belongsTo(Character::class, 'characterId');
    }
}
