<?php

namespace Database\Seeders;

use App\Models\Tipos;
use Illuminate\Database\Seeder;

class TiposSeeder extends Seeder
{
    public function run()
    {
        Tipos::insert([
            [
                "nombre"        => "Desigualdad social",
                "descripcion"   => "pendiente"
            ],[
                "nombre"        => "Desigualdad económica",
                "descripcion"   => "pendiente"
            ],[
                "nombre"        => "Desigualdad educativa",
                "descripcion"   => "pendiente"
            ],[
                "nombre"        => "Desigualdad de género",
                "descripcion"   => "pendiente"
            ],[
                "nombre"        => "Desigualdad legal",
                "descripcion"   => "pendiente"
            ]
        ]);
    }
}
