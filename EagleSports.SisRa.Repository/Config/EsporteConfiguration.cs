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
            throw new NotImplementedException();
        }
    }
}
