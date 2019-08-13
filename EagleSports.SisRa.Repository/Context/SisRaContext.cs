using EagleSports.SisRa.Domain.Entities;
using EagleSports.SisRa.Repository.Config;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Repository.Context
{
    public class SisRaContext: DbContext
    {

        public DbSet<Atleta> Atletas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Esporte> Esportes { get; set; }
        public DbSet<HistoricoVideo> HistoricoVideos { get; set; }
        public SisRaContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtletaConfiguration());
            modelBuilder.ApplyConfiguration(new EsporteConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new HistoricoVideoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            base.OnModelCreating(modelBuilder);
        }


    }
}
