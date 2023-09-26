using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVenta.BLL.Interfaces;
using System.Security.Cryptography;
using SistemaVenta.DAL.Interfaces;

namespace SistemaVenta.DAL.Implementacion
{
    public class UtilidadesService : IUtilidadesService
    {
        public string GenerarClave()
        {
            string clave = Guid.NewGuid().ToString("N").Substring(0,6); //"Guid.NewGuild": Retorna una cadena de texto aleatoria
            return clave;
        }

        public string ConvertirSha256(string texto)
        {
           StringBuilder sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create()) //Solo estamos creando el objeto para encriptar el texto
            {
                Encoding enc = Encoding.UTF8;

                byte[] result = hash.ComputeHash(enc.GetBytes(texto));
                
                foreach(byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                } //Esto es codigo por defecto para encriptar el texto en SHA256
            }
            return sb.ToString();
        }

       
    }
}
