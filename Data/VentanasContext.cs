using Microsoft.EntityFrameworkCore;
using EvaluacionTecnica.Models;

namespace EvaluacionTecnica.Data
{

    public class VentasContext : DbContext
    {

        public VentasContext(DbContextOptions<VentasContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

    }
}
