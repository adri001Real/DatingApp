using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions options) : base(options)//pasa una cadena de conexion para conectar a la BD
        {

        }

        public DbSet<AppUser> Users{ get; set; } //esta recibiendo una tabla

    }
}