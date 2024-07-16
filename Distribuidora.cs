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
    }   