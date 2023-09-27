using SistemaVenta.Entity;

namespace SistemaVenta.AplicacionWeb.Models.ViewModels
{
    public class VMRol
    {
        
        public int IdRol { get; set; }

        public string? Descripcion { get; set; }

       
    }
}
// ViewModel es practicamente lo mismo que el modelo pero se sacan las propiedas que vamos a necesitar para poder interactuar con nuestra vista
