using System;
using System.Collections.Generic;

public class Actividades{

    public string Candidato;
    public string Fecha_de_la_actividad;
    public string Descripcion;
    public string Costos;
    public string Lugar;
}

public class Manejador_Actividades{

    private List<Actividades> todos = new List<Actividades>();

    public void agregarActividades(Actividades act){
        todos.Add(act);
    }

    public List<Actividades> optenerActividades()
    {
        return todos;
    }
}