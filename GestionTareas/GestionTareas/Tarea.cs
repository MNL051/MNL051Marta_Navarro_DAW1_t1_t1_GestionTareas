using System.Data.Common;
using System.Dynamic;
using System.Windows.Markup;

class Tarea{

    private string? nombreTarea;
    private string? descripcionTarea;
    private bool?  prioridadTarea;
    private TipoTarea? tipoTarea;


    private int? id;

    public string? NombreTarea {get => nombreTarea; set => nombreTarea = value;}
    public string? DescripcionTarea {get => descripcionTarea; set => descripcionTarea = value;}
    public TipoTarea? Tipotarea {get => tipoTarea; set => tipoTarea = value;}
    public bool? PrioridadTarea {get => prioridadTarea; set => prioridadTarea = value;}

    public int? Id {get=> id; set =>id = value;}
}

enum TipoTarea{
    Persona,
    Trabajo,
    Ocio,
}