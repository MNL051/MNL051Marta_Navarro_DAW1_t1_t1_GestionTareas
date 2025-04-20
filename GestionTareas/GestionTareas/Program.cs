using System;
class Program
{
     static List <Tarea> tareas = new List<Tarea>();
    static void Main(string[] args)
    {
       
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

        Console.WriteLine("¿Que prioridad tiene la tarea?: "); //por añadir

        tareas.Add(new Tarea{NombreTarea = nombreTarea, DescripcionTarea = descripcionTarea, Tipotarea = tipoTarea});
        Console.WriteLine("Tarea registrada");

    }
 
     static void BuscarTarea(){  
        Console.WriteLine("¿Que tipo de tarea desea buscar?");

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
            Console.WriteLine("Tareas del tipo " + tipoTarea + " encontradas:");
            foreach (var tarea in tareasFiltradas)
            {
                //Console.WriteLine("Nombre: " + tarea.NombreTarea +", Descripción: " + tarea.DescripcionTarea +", Prioridad: " + tarea.PrioridadTarea);
                Console.WriteLine("Nombre: " + tarea.NombreTarea);
                Console.WriteLine("Descripción: " + tarea.DescripcionTarea);
                Console.WriteLine("Prioridad: " + tarea.PrioridadTarea);
            }
        }
        else
        {
            Console.WriteLine("\nNo se encontraron tareas de ese tipo.");
        }

    }

    static void ElminarTarea(){ //necesita id 

    }
}
