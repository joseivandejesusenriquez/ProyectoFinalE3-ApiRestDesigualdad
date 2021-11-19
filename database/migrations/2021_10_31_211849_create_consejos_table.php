<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateConsejosTable extends Migration
{
    public function up()
    {
        Schema::create('consejos', function (Blueprint $table) {
            $table->id();
            $table->foreignId('tipo')->comment('ID del tipo de desigualdad')->references('id')->on('tipos')->onUpdate('cascade')->onDelete('cascade');
            $table->text('contenido');
            $table->timestamps();
        });
    }

    public function down()
    {
        Schema::dropIfExists('consejos');
    }
}
