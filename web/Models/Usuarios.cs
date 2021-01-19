using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Usuarios.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Correo { get; set; }

    }
}