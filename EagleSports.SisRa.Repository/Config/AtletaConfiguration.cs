using EagleSports.SisRa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Repository.Config
{
    public class AtletaConfiguration : IEntityTypeConfiguration<Atleta>
    {
        public void Configure(EntityTypeBuilder<Atleta> builder)
        {
            throw new NotImplementedException();
        }
    }
}
