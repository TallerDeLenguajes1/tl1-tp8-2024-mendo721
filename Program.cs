using EspacioDistribuidora;
using System;
using System.Collections.Generic;

List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();
Random random = new Random();
Console.WriteLine("\nQue cantidad de tareas desea ingresar: ");
string cantidad = Console.ReadLine();
int cant;
int.TryParse(cantidad, out cant);
int menu;

for (int i = 0; i < cant; i++)
{
    Console.WriteLine("\nIngrese la descripcion de la tarea: ");
    string descripcion = Console.ReadLine();
    Tarea tarea = new Tarea(i, descripcion, random.Next(10, 100));
    TareasPendientes.Add(tarea);
}
//MENU

Console.WriteLine("\nMenu\n1. Marcar tarea como realizada\n3. Mostrar tareas pendientes\n4. Mostrar tareas realizadas\n5. Salir\n\nIngrese una opcion: ");
string opcion = Console.ReadLine();
int.TryParse(opcion, out menu);

//Inicializar el id para las tareas pendientes


switch (menu)
{
    case 1: 
        Console.WriteLine("\n----Tareas Pendientes----\n");
        Tarea.MostrarTarea(TareasPendientes);
        Console.WriteLine("\nIngrese el id de la tarea que desea marcar como realizada: ");
        string id = Console.ReadLine();
        int idT;
        int.TryParse(id, out idT);
        for (int i = 0; i < TareasPendientes.Count; i++)
        {
            if (idT == TareasPendientes[i].TareaID)
            {
                TareasRealizadas.Add(TareasPendientes[idT]);
                TareasPendientes.Remove(TareasPendientes[idT]);
                Console.WriteLine($"Tarea {id} movida a realizadas.");
            }
            
        }
        break;
    case 2:
        Console.WriteLine("\nIngrese la descripcion de la tarea que desea buscar: ");
        string descripcion = Console.ReadLine();
        for (int i = 0; i < TareasPendientes.Count; i++)
        {
            if (descripcion == TareasPendientes[i].Descripcion)
            {
                Console.WriteLine("Tarea encontrada");
                Console.WriteLine(TareasPendientes[i].Descripcion);
                Console.WriteLine(TareasPendientes[i].TareaID);
                Console.WriteLine(TareasPendientes[i].Duracion);
            }
        }
        break;
}

Console.WriteLine("\n----Tareas Realizadas----\n");
Tarea.MostrarTarea(TareasRealizadas);

Console.WriteLine("\n----Tareas Pendientes----\n");
Tarea.MostrarTarea(TareasPendientes);
