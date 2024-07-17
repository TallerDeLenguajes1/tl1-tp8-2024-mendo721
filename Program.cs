using EspacioDistribuidora;
using System.Collections.Generic;

List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();
Random random = new Random();

//MENU
Console.WriteLine("\nMenu\n1. Ingresar una tarea\n2. Marcar tarea como realizada\n3. Mostrar tareas pendientes\n4. Mostrar tareas realizadas\n5. Salir\n\nIngrese una opcion: ");
string opcion = Console.ReadLine();
int opc;
int.TryParse(opcion, out opc);

//Inicializar el id para las tareas pendientes
int indicePendientes = 0;


switch (opc)
{
    case 1: 
    indicePendientes ++;
    Console.WriteLine("\nIngrese la descripcion de la tarea: ");
    string descripcion = Console.ReadLine();
    Tarea tarea = new Tarea(indicePendientes, descripcion, random.Next(10, 100));
    TareasPendientes.Add(tarea);
    break; 
}
