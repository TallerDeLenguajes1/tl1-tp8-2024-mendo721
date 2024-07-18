using System.Dynamic;

namespace EspacioDistribuidora;

    public class Tarea{
        public int TareaID;
        public string Descripcion;
        public int Duracion;
    
        public Tarea(int tareaId, string descripcion, int duracion){
            TareaID = tareaId;
            Descripcion = descripcion;
            Duracion = duracion;
        }

        public int IdTarea{ get => TareaID; set => TareaID = value;}
        public string descripcion{get => Descripcion; set => Descripcion = value;}
        public int duracion{get => Duracion; set => Duracion = value;}

        static public void MostrarTarea(List<Tarea> tareas){
            foreach (Tarea tarea in tareas)
            {
                Console.WriteLine("\n--Tarea--");
                Console.WriteLine($"\nId: {tarea.TareaID}");
                Console.WriteLine($"\nDescripcion: {tarea.Descripcion}");
                Console.WriteLine($"\nDuracion: {tarea.Duracion}");
            }
        }
    }   
