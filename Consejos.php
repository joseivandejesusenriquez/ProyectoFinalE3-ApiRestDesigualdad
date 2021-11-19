<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Consejos extends Model
{
    protected $table = 'consejos';
    protected $fillable = ['tipo', 'contenido'];
    //public $timestamps = false;
}
