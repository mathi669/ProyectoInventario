using Microsoft.EntityFrameworkCore;

namespace Inventario.backendV2.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Producto> Productos { get; set; } = null!;
        public DbSet<Operacion> Operaciones { get; set; } = null!;


    }   
}
