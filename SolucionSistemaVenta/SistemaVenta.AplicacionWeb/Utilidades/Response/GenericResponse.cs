namespace SistemaVenta.AplicacionWeb.Utilidades.Response
{
    public class GenericResponse<TObject> //Esta clase se va estar utilizando como respuesta a todas las solicitudes que se hagan al sitio web
    {

        public bool Estado { get; set; }

        public string? Mensaje { get; set; }
        public TObject? Objeto { get; set; }

        public List<TObject>? ListaObjeto {get; set;}
    }
}

//queso
//prueba