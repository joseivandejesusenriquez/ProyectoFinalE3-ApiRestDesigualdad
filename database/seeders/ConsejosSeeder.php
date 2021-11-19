<?php

namespace Database\Seeders;

use App\Models\Consejos;
use Illuminate\Database\Seeder;

class ConsejosSeeder extends Seeder
{
    public function run()
    {
        Consejos::insert([
            [
                "tipo"          => 1,
                "contenido"     => "Consejo sobre Social #1",
            ], [
                "tipo"          => 1,
                "contenido"     => "Consejo sobre Social #2",
            ], [
                "tipo"          => 2,
                "contenido"     => "Consejo sobre Economico #1",
            ], [
                "tipo"          => 2,
                "contenido"     => "Consejo sobre Economico #2",
            ], [
                "tipo"          => 3,
                "contenido"     => "Consejo sobre Educativa #1",
            ], [
                "tipo"          => 3,
                "contenido"     => "Consejo sobre Educativa #2",
            ], [
                "tipo"          => 4,
                "contenido"     => "Consejo sobre Género #1",
            ], [
                "tipo"          => 4,
                "contenido"     => "Consejo sobre Género #2",
            ], [
                "tipo"          => 5,
                "contenido"     => "Consejo sobre Legal #1",
            ], [
                "tipo"          => 5,
                "contenido"     => "Consejo sobre Legal #2",
            ]
        ]);
    }
}