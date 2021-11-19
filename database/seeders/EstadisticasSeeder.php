<?php

namespace Database\Seeders;

use App\Models\Estadisticas;
use Illuminate\Database\Seeder;

class EstadisticasSeeder extends Seeder
{
    public function run()
    {
        Estadisticas::insert([
            [
                "tipo"          => 1,
                "municipio"     => 100,
                "porcentaje"    => 20,
            ], [
                "tipo"          => 2,
                "municipio"     => 100,
                "porcentaje"    => 18,
            ], [
                "tipo"          => 3,
                "municipio"     => 100,
                "porcentaje"    => 36,
            ], [
                "tipo"          => 4,
                "municipio"     => 100,
                "porcentaje"    => 42,
            ], [
                "tipo"          => 5,
                "municipio"     => 100,
                "porcentaje"    => 12,
            ], [
                "tipo"          => 3,
                "municipio"     => 1,
                "porcentaje"    => 12,
            ], [
                "tipo"          => 5,
                "municipio"     => 1,
                "porcentaje"    => 23,
            ], [
                "tipo"          => 4,
                "municipio"     => 2,
                "porcentaje"    => 98,
            ]
        ]);
    }
}