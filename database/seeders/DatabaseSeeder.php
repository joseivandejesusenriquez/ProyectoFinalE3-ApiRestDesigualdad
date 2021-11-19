<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;

class DatabaseSeeder extends Seeder
{
    public function run()
    {
        $this->call([
            TiposSeeder::class,
            MunicipiosSeeder::class,

            ConsejosSeeder::class,
            EstadisticasSeeder::class,
        ]);
    }
}
