using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiMascota.Models;

namespace DataAccess
{

    public class MascotaContext : DbContext
    {
        public MascotaContext(DbContextOptions<MascotaContext> options)
          : base(options)
        {
        }
        public DbSet<Mascota> Mascotas { get; set; }
    }
}
