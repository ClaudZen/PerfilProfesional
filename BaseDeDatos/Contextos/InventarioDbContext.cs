using System.Collections.Generic;
using BaseDeDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.Contextos
{
    public class InventarioDbContext : DbContext
    {
        public InventarioDbContext(DbContextOptions<InventarioDbContext> options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categorias = new List<Categoria>() {
                new Categoria() { Id =1,Nombre="Juegos"} ,
                new Categoria(){Id=2,Nombre="Computación"},
                new Categoria(){Id=3,Nombre="Parlantes"}
                };
            var productos=new List<Producto>(){
                new Producto(){Id=1,Nombre="God Of War",Stock=2,Precio=15000,IdCategoria=1},
                new Producto(){Id=2,Nombre="Halo Infinite",Stock=10,Precio=50000,IdCategoria=1},
                new Producto(){Id=3,Nombre="Mouse Macro Gaming",Stock=4,Precio=10000,IdCategoria=2},
                new Producto(){Id=4,Nombre="Audifonos Pc Macro Gaming",Stock=20,Precio=18000,IdCategoria=2},
                new Producto(){Id=5,Nombre="Parlante Genius",Stock=15,Precio=22000,IdCategoria=3},
                new Producto(){Id=6,Nombre="Parlante Master G",Stock=8,Precio=25000,IdCategoria=3},
            };

            modelBuilder.Entity<Categoria>().HasData(categorias.ToArray());
            modelBuilder.Entity<Producto>().HasData(productos.ToArray());
        }
    }
}