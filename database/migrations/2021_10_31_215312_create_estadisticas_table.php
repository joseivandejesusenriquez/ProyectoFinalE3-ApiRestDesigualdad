<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateEstadisticasTable extends Migration
{
    public function up()
    {
        Schema::create('estadisticas', function (Blueprint $table) {
            $table->id();
            $table->foreignId('tipo')->comment('ID del tipo de desigualdad')->references('id')->on('tipos')->onUpdate('cascade')->onDelete('cascade');
            $table->foreignId('municipio')->comment('ID del municipio')->references('id')->on('municipios')->onUpdate('cascade')->onDelete('cascade');
            $table->double('porcentaje', 5,2)->default(0);
            $table->timestamps();
        });
    }

    public function down()
    {
        Schema::dropIfExists('estadisticas');
    }
}
