using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
     static List <Tarea> tareas = new List<Tarea>();
    static void Main(string[] args)
    {
       bool continuar = true;
       while (continuar){

        Console.WriteLine("\nMenú de tareas, por favor seleccione una opción: ");
        Console.WriteLine("1.Crear tarea");
        Console.WriteLine("2.Buscar tarea por tipo");  
        Console.WriteLine("3.Eliminar tarea");

        string? opcion = Console.ReadLine(); 

        switch (opcion)
        {
            case "1":
                CrearTarea();
                break;

            case "2":
                BuscarTarea();
                break;

            case "3":
                ElminarTarea();
                break;

            default:
                Console.WriteLine("\nTérmino erróneo. Intenteló de nuevo");
                break;
        }

       }
    }

    static void CrearTarea(){ //falta asignar id automaticamnte y unico  

        Console.WriteLine("Ingrese el nombre de la tarea: ");
        string? nombreTarea = Console.ReadLine();

        Console.WriteLine("Ingrese una breve descripcion: "); 
        string? descripcionTarea = Console.ReadLine(); 

        Console.WriteLine("¿De que tipo es la tarea? ¿Persona, Trabajo u Ocio?: ");
        string? tipo = Console.ReadLine();
        TipoTarea tipoTarea; //para inicializar el tipo de tarea es necesrario trasnformar el string a un enum 
        while (!Enum.TryParse(tipo, true, out tipoTarea))
        {
            Console.WriteLine("Tipo erróneo. Por favor, ingrese un tipo válido (Persona, Trabajo u Ocio): ");
            tipo = Console.ReadLine();
        }

        Console.WriteLine("¿La tarea es prioritaria?: "); //por terminar la prioridad salga mensaje de Si o No 
      
        tareas.Add(new Tarea{NombreTarea = nombreTarea, DescripcionTarea = descripcionTarea, Tipotarea = tipoTarea,});
        Console.WriteLine("Tarea registrada");

        Console.WriteLine("\nPresione cualquier tecla para volver al menú: ");
        Console.ReadKey();

    }
 
     static void BuscarTarea(){  

        Console.WriteLine("¿Que tipo de tarea desea buscar (Persona, Trabajo u Ocio)?");

        string? tipo = Console.ReadLine();
        TipoTarea tipoTarea;
         while (!Enum.TryParse(tipo, true, out tipoTarea))
        {
            Console.WriteLine("Tipo erróneo. Por favor, ingrese un tipo válido (Persona, Trabajo u Ocio): ");
            tipo = Console.ReadLine();
        }

        var tareasFiltradas = tareas.Where(t => t.Tipotarea == tipoTarea).ToList();
        //tareasFiltradas para guardar las tareas solicitadas
        /* where para filtrar, donde cada tarea "t" de la lista me de solo las que sean iguales a las del tipo que busco */

        if (tareasFiltradas.Any())
        /*"Any" me verifica si hay un elemento en la lista y me devuelve un true si hay o un false si esta vacia */
        {
            Console.WriteLine("\nTareas del tipo " + tipoTarea + " encontradas:");
            foreach (var tarea in tareasFiltradas)
            {
                //Console.WriteLine("Nombre: " + tarea.NombreTarea +", Descripción: " + tarea.DescripcionTarea +", Prioridad: " + tarea.PrioridadTarea);
                Console.WriteLine("Id: " + tarea.IdTarea);
                Console.WriteLine("Nombre: " + tarea.NombreTarea);
                Console.WriteLine("Descripción: " + tarea.DescripcionTarea);
                Console.WriteLine("Prioridad: " + tarea.PrioridadTarea);
            }
        }
        else
        {
            Console.WriteLine("\nNo se encontraron tareas de ese tipo");
        }

    }

    static void ElminarTarea(){ 

    Console.WriteLine("Ingrese el id de la tarea a eliminar: ");

    if(int.TryParse(Console.ReadLine(), out int idTarea))
    {
        var tareaAEliminar = tareas.FirstOrDefault(t => t.IdTarea == idTarea);

        if (tareaAEliminar != null)
        {
            tareas.Remove(tareaAEliminar);
            Console.WriteLine("Tarea"+ idTarea +"eliminada con éxito");
        }
        else
        {
            Console.WriteLine("No se encontró una tarea con ese Id");
        }
    }
        else
        {
            Console.WriteLine("Id inválido. Por favor, ingrese un número válido.");
            Console.ReadKey();


        }
        Console.WriteLine("\nPresione cualquier tecla para volver al menú:");
        Console.ReadKey();

    }
}
