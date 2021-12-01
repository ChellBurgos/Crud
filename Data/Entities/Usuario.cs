using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public int IdRol { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public string Nombre_Usuario { get; set; }

        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
