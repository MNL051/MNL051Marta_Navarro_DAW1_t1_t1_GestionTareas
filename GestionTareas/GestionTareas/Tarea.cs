using System.Data.Common;
using System.Dynamic;
using System.Windows.Markup;

class Tarea{

    private static int idContador = 1;
    private string? nombreTarea;
    private string? descripcionTarea;
    private bool?  prioridadTarea;
    private TipoTarea? tipoTarea;
    private int idTarea;

    //Constructor  
     public Tarea(){
     idTarea = idContador++;   
    }     

    //Constructor  
    public Tarea(int idContador, string nombreTarea, string descripcionTarea, TipoTarea tipoTarea, bool prioridadTarea){
        this.nombreTarea = nombreTarea;
        this.descripcionTarea = descripcionTarea;
        this.tipoTarea = tipoTarea;
        this.prioridadTarea = prioridadTarea;
        this.idTarea = idContador;
    }

    public string? NombreTarea {get => nombreTarea; set => nombreTarea = value;}
    public string? DescripcionTarea {get => descripcionTarea; set => descripcionTarea = value;}
    public TipoTarea? Tipotarea {get => tipoTarea; set => tipoTarea = value;}
    public bool? PrioridadTarea {get => prioridadTarea; set => prioridadTarea = value;}
    public int IdTarea {get=> idTarea; set =>idTarea = value;}
    
    }

enum TipoTarea{
    Persona,
    Trabajo,
    Ocio,
}