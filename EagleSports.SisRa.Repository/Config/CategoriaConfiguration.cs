using EagleSports.SisRa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Repository.Config
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .HasMaxLength(3)
                .HasColumnType("number");


            //builder
            //    .Property(u => u.IdEsporte)
            //    .IsRequired()
            //    .HasMaxLength(50);


        }
    }
}
