using EagleSports.SisRa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Repository.Config
{
    public class HistoricoVideoConfiguration : IEntityTypeConfiguration<HistoricoVideo>
    {
        public void Configure(EntityTypeBuilder<HistoricoVideo> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.UrlVideo)
                .HasMaxLength(400)
                .IsRequired();

            //builder
            //    .Property(u => u.IdAtleta)
            //    .HasMaxLength(50);

            //builder
            //    .Property(u => u.IdEsporte)
            //    .IsRequired()
            //    .HasMaxLength(50);



        }
    }
}
