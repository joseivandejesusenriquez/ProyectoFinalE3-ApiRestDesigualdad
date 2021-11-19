<?php

namespace App\Http\Controllers;

use App\Models\Tipos;
use App\Models\Consejos;
use App\Models\Municipios;
use App\Models\Estadisticas;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Validator;

class ApiController extends Controller
{
    public function listado_tipos()
    {
        $tipos = Tipos::all();

        return response()->json([
            'result'        => $tipos,
            'message'       => NULL,
            'count'         => $tipos->count()
        ]);
    }

    public function obtener_tipo(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'tipo'      =>'required|exists:tipos,id',
        ], [
            'tipo.required'     =>'Indique el tipo de discriminación',
            'tipo.exists'       =>'El tipo de discriminación no existe',
        ]);
        if ($validator->fails())
		{
			return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
		}

        try
        {
            $tipo = Tipos::findOrFail($request->tipo);
            
            return response()->json([
                'result'        => $tipo,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }

    public function guardar_tipo(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'nombre'            =>'required|string|max:255',
            'descripcion'       =>'required|string',
        ], [
            'nombre.required'           =>'Indique el nombre para el tipo de discriminación',
            'nombre.max'                =>'Máximo 255 caracteres',
            'descripcion.required'      =>'Indique una descripción',
        ]);
        if ($validator->fails())
        {
            return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
        }

        try
        {
            Tipos::create([
                "nombre"            => $request->nombre,
                "descripcion"       => $request->descripcion,
            ]);

            return response()->json([
                'result'        => true,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }

    public function actualizar_tipo(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'tipo'                      =>'required|exists:tipos,id',
            'nombre'                    =>'required|string|max:255',
            'descripcion'               =>'required|string',
        ], [
            'tipo.required'             =>'Indique el tipo de discriminación',
            'tipo.exists'               =>'El tipo de discriminación no existe',
            'nombre.required'           =>'Indique el nombre para el tipo de discriminación',
            'nombre.max'                =>'Máximo 255 caracteres',
            'descripcion.required'      =>'Indique una descripción',
        ]);
        if ($validator->fails())
        {
            return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
        }

        try
        {
            $tipo = Tipos::findOrFail($request->tipo);
            $tipo->nombre       = $request->nombre;
            $tipo->descripcion  = $request->descripcion;
            $tipo->save();
            
            return response()->json([
                'result'        => true,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }

    public function eliminar_tipo(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'tipo'      =>'required|exists:tipos,id',
        ], [
            'tipo.required'     =>'Indique el tipo de discriminación',
            'tipo.exists'       =>'El tipo de discriminación no existe',
        ]);
        if ($validator->fails())
        {
            return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
        }

        try
        {
            Tipos::destroy($request->tipo);
            return response()->json([
                'result'        => true,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }


    public function listado_municipios()
    {
        $municipios = Municipios::orderby('nombre')->get();
        return response()->json([
            'result'        => $municipios,
            'message'       => NULL,
            'count'         => $municipios->count()
        ]);
    }

    public function listado_consejos(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'tipo'      =>'required|exists:tipos,id',
        ], [
            'tipo.required'     =>'Indique el tipo de discriminación',
            'tipo.exists'       =>'El tipo de discriminación no existe',
        ]);
        if ($validator->fails())
		{
			return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
		}

        $consejos = Consejos::where('tipo', $request->tipo)->get();
        return response()->json([
            'result'        => $consejos,
            'message'       => NULL,
            'count'         => $consejos->count()
        ]);
    }

    public function obtener_consejo(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'consejo'      =>'required|exists:consejos,id',
        ], [
            'consejo.required'     =>'Indique el ID del consejo',
            'consejo.exists'       =>'El consejo no existe',
        ]);
        if ($validator->fails())
		{
			return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
		}

        try
        {
            $consejo = Consejos::select("consejos.*", "tipos.nombre as tipo_nombre")->join("tipos", "tipos.id", "consejos.tipo")->findOrFail($request->consejo);
            
            return response()->json([
                'result'        => $consejo,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }

    public function guardar_consejo(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'tipo'                  =>'required|exists:tipos,id',
            'consejo'               =>'required|string',
        ], [
            'tipo.required'         =>'Indique el tipo de discriminación',
            'tipo.exists'           =>'El tipo de discriminación indicado no fue encontrado',
            'consejo.required'      =>'Proporcione el consejo',
        ]);
        if ($validator->fails())
        {
            return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
        }

        try
        {
            Consejos::create([
                "tipo"          => $request->tipo,
                "contenido"     => $request->consejo,
            ]);

            return response()->json([
                'result'        => true,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }

    public function actualizar_consejo(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'consejo'       =>'required|exists:consejos,id',
            'tipo'          =>'required|exists:tipos,id',
            'contenido'     =>'required|string',
        ], [
            'consejo.required'          =>'Indique el ID del consejo',
            'consejo.exists'            =>'El consejo no existe',
            'tipo.required'             =>'Indique el tipo de discriminación',
            'tipo.exists'               =>'El tipo de discriminación no existe',
            'contenido.required'          =>'Proporcione el consejo',
        ]);
        if ($validator->fails())
        {
            return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
        }

        try
        {
            $consejo = Consejos::findOrFail($request->consejo);
            $consejo->tipo       = $request->tipo;
            $consejo->contenido  = $request->contenido;
            $consejo->save();
            
            return response()->json([
                'result'        => true,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }

    public function eliminar_consejo(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'consejo'      =>'required|exists:consejos,id',
        ], [
            'consejo.required'     =>'Indique el ID del consejo',
            'consejo.exists'       =>'El consejo no existe',
        ]);
        if ($validator->fails())
        {
            return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
        }

        try
        {
            Consejos::destroy($request->consejo);
            return response()->json([
                'result'        => true,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }

    public function listado_estadisticas(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'municipio'      =>'required|exists:municipios,id',
        ], [
            'municipio.required'     =>'Indique el municipio',
            'municipio.exists'       =>'El municipio no existe',
        ]);
        if ($validator->fails())
		{
			return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
		}

        $estadisticas = Estadisticas::select('estadisticas.id', 'estadisticas.porcentaje', 'estadisticas.tipo', 'tipos.nombre as tipo_nombre')
            ->join('tipos', 'tipos.id', 'estadisticas.tipo')
            ->where('estadisticas.municipio', $request->municipio)
            ->orderby('porcentaje', 'desc')
            ->get();

        return response()->json([
            'result'        => $estadisticas,
            'message'       => NULL,
            'count'         => $estadisticas->count()
        ]);
    }

    public function obtener_estadistica(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'estadistica'      =>'required|exists:estadisticas,id',
        ], [
            'estadistica.required'     =>'Indique el ID de la estadistica',
            'estadistica.exists'       =>'La estadistica no existe',
        ]);
        if ($validator->fails())
		{
			return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
		}

        try
        {
            $estadistica = Estadisticas::select("estadisticas.*", "tipos.nombre as tipo_nombre", "municipios.nombre as municipio_nombre")
                ->join("tipos", "tipos.id", "estadisticas.tipo")
                ->join("municipios", "municipios.id", "estadisticas.municipio")
                ->findOrFail($request->estadistica);
            
            return response()->json([
                'result'        => $estadistica,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }

    public function guardar_estadistica(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'tipo'                  =>'required|exists:tipos,id',
            'municipio'             =>'required|exists:municipios,id',
            'porcentaje'            =>'required|numeric|between:0,100',
        ], [
            'tipo.required'         =>'Indique el tipo de discriminación',
            'tipo.exists'           =>'El tipo de discriminación indicado no fue encontrado',
            'municipio.required'    =>'Indique el municipio',
            'municipio.exists'      =>'El municipio no existe',
            'porcentaje.required'   =>'Proporcione porcentaje',
            'porcentaje.required'   =>'Dato no valido',
            'porcentaje.required'   =>'Porcentaje no valido: mínimo: 0 máximo: 100',
        ]);
        if ($validator->fails())
        {
            return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
        }

        try
        {
            $estadistica = Estadisticas::where([["tipo", $request->tipo], ["municipio", $request->municipio]])->count();
            if($estadistica == 0)
            {
                Estadisticas::create([
                    "tipo"          => $request->tipo,
                    "municipio"     => $request->municipio,
                    "porcentaje"    => $request->porcentaje,
                ]);
    
                return response()->json([
                    'result'        => true,
                    'message'       => NULL,
                    'count'         => 1
                ]);
            }else{
                return response([
                    'result'        => null,
                    'message'       => "El dato que desea indicar ya existe",
                    'count'         => 0
                ], 422);
            }
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }

    public function actualizar_estadistica(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'estadistica'           =>'required|exists:estadisticas,id',
            'tipo'                  =>'required|exists:tipos,id',
            'municipio'             =>'required|exists:municipios,id',
            'porcentaje'            =>'required|numeric|between:0,100',
        ], [
            'tipo.required'         =>'Indique el ID de la estadistica',
            'tipo.exists'           =>'La estadistica indicado no fue encontrado',
            'tipo.required'         =>'Indique el tipo de discriminación',
            'tipo.exists'           =>'El tipo de discriminación indicado no fue encontrado',
            'municipio.required'    =>'Indique el municipio',
            'municipio.exists'      =>'El municipio no existe',
            'porcentaje.required'   =>'Proporcione porcentaje',
            'porcentaje.required'   =>'Dato no valido',
            'porcentaje.required'   =>'Porcentaje no valido: mínimo: 0 máximo: 100',
        ]);
        if ($validator->fails())
        {
            return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
        }

        try
        {
            $estadistica = Estadisticas::findOrFail($request->estadistica);;
            $estadistica->tipo          = $request->tipo;
            $estadistica->municipio     = $request->municipio;
            $estadistica->porcentaje    = $request->porcentaje;
            $estadistica->save();

            return response()->json([
                'result'        => true,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }

    public function eliminar_estadistica(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'estadistica'      =>'required|exists:estadisticas,id',
        ], [
            'estadistica.required'     =>'Indique el ID de la estadistica',
            'estadistica.exists'       =>'El estadistica no existe',
        ]);
        if ($validator->fails())
        {
            return response([
                'result'        => null,
                'message'       => $validator->errors()->all(),
                'count'         => 0
            ], 422);
        }

        try
        {
            Estadisticas::destroy($request->estadistica);
            return response()->json([
                'result'        => true,
                'message'       => NULL,
                'count'         => 1
            ]);
        }
        catch (\Throwable $th) {
            return response([
                'result'        => null,
                'message'       => $th->getMessage(),
                'count'         => 0
            ], 422);
        }
    }
}
