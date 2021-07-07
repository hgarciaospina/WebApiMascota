using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMascota.Models;

namespace WebApiMascota.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        public List<Mascota> mascotas = new()
        {
            new Mascota { Id = 1, NombreMascota = "Amatista", TipoMascota ="Gato", AnioNacimiento = 2021, NombrePropietario = "Luisa Alejandra García"},
            new Mascota { Id = 2, NombreMascota = "Peluche", TipoMascota ="Perro", AnioNacimiento = 2014, NombrePropietario = "Henry García O"},
            new Mascota { Id = 3, NombreMascota = "Cookie", TipoMascota ="Hamster", AnioNacimiento = 2020, NombrePropietario = "Emma Ospina"},
        };
        [HttpGet]
        public ActionResult<IEnumerable<Mascota>> GetAllMascotas()
        {
            return Ok(mascotas);
        }

        [HttpGet("{id}")]
        public ActionResult<Mascota> GetMascotaById(int id)
        {
            var mascota = mascotas.FirstOrDefault(m => m.Id == id);
            if (mascota == null)
            {
                return NotFound($"La mascota de Id {id} NO existe...");
            }

            return mascota;

        }
    }
}
