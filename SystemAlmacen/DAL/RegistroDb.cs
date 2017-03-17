using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace DAL
{
   public class RegistroDb : DbContext
    {
        public RegistroDb(): base ("ConStr")
        {

        }

        public DbSet<Articulos> articuloDb { get; set; }
        public DbSet<Usuarios> usuarioDb { get; set; }
        public DbSet <Clientes>clientesDb { get; set; }
        public DbSet<Categorias> categoriaDb { get; set; }
/*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Categorias>()
                .HasMany(categoria => categoria.articulo)
                .WithMany(articulo => articulo.categoria)
                .Map(ArticuloCategoria =>
                {
                    ArticuloCategoria.MapLeftKey("IdArticulo");
                    ArticuloCategoria.MapRightKey("CategoriaId");
                    ArticuloCategoria.ToTable("ArticuloCategorias");
                }

                );

    
        }
        */

    }
}
