using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMascota.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string NombreMascota { get; set; }

        public int AnioNacimiento { get; set; }
        public string TipoMascota { get; set; }
        public string NombrePropietario { get; set; }
    }
}
