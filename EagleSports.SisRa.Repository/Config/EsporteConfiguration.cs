using EagleSports.SisRa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Repository.Config
{
    public class EsporteConfiguration : IEntityTypeConfiguration<Esporte>
    {
        public void Configure(EntityTypeBuilder<Esporte> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .HasMaxLength(50)
                .HasColumnType("number");
        }

    }
}
