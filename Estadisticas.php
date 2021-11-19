<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Estadisticas extends Model
{
    protected $table = 'estadisticas';
    protected $fillable = ['tipo', 'municipio', 'porcentaje'];
    //public $timestamps = false;
}
