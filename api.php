<?php
Route::prefix('municipios')->group(function () {
    Route::get('listado','ApiController@listado_municipios');               //Listado de los municipios de Chiapas
});

Route::prefix('tipos')->group(function () {
    Route::get('listado','ApiController@listado_tipos');                    //Listado de los tipos de discriminación
    Route::post('obtener','ApiController@obtener_tipo');                    //Obtener los datos de 1 tipo de discriminación (Busqueda por ID)
    Route::post('guardar','ApiController@guardar_tipo');                    //Guardar un nuevo tipo de discriminación (nuevo registro)
    Route::post('actualizar','ApiController@actualizar_tipo');              //Actualizar la información de un tipo de discriminación (actualizar registro por ID)
    Route::post('eliminar','ApiController@eliminar_tipo');                  //Eliminar un tipo de discriminación (Borrado por ID)
});

Route::prefix('consejos')->group(function () {
    Route::post('listado','ApiController@listado_consejos');                //Listado consejos contra la discriminación (Por ID de la discriminación)
    Route::post('obtener','ApiController@obtener_consejo');                 //Obtener los datos de 1 consejo (Busqueda por ID)
    Route::post('guardar','ApiController@guardar_consejo');                 //Guardar un nuevo consejo (nuevo registro)
    Route::post('actualizar','ApiController@actualizar_consejo');           //Actualizar la información de un consejo (actualizar registro por ID)
    Route::post('eliminar','ApiController@eliminar_consejo');               //Eliminar un consejo (Borrado por ID)
});

Route::prefix('estadisticas')->group(function () {
    Route::post('listado','ApiController@listado_estadisticas');            //Listado de la estadistica de la discriminación por municipio (Por ID del municipio)
    Route::post('obtener','ApiController@obtener_estadistica');             //Obtener los datos estadisticos (Busqueda por ID)
    Route::post('guardar','ApiController@guardar_estadistica');             //Guardar un nuevo dato estadistico (nuevo registro)
    Route::post('actualizar','ApiController@actualizar_estadistica');       //Actualizar la información de una estadistica (actualizar registro por ID)
    Route::post('eliminar','ApiController@eliminar_estadistica');           //Eliminar una estadistica (Borrado por ID)
});