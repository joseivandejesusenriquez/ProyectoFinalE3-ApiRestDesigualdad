<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Tipos extends Model
{
    protected $table = 'tipos';
    protected $fillable = ['nombre', 'descripcion'];
    public $timestamps = false;
}
