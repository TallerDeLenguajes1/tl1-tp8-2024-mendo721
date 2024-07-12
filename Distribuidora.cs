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
    }