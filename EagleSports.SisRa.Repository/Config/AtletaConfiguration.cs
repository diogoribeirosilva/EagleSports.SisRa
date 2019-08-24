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
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Altura)
                .HasMaxLength(3)
                .HasColumnType("number");

            builder
                .Property(u => u.Avaliador)
                .HasMaxLength(50);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.DataNascimento)
                .HasColumnType("DateTime");

            builder
                .Property(u => u.Email)
                .HasMaxLength(200);

            builder
                .Property(u => u.Equipe)
                .HasMaxLength(50);

            builder
                .Property(u => u.Hastag)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.Numero)
                .HasMaxLength(2);

            builder
                .Property(u => u.Peso)
                .HasMaxLength(3);
            builder
                .Property(u => u.Skill)
                .HasMaxLength(50);

            builder
                .Property(u => u.Telefone)
                .HasMaxLength(50);


            builder
                .HasMany(u => u.Esportes)
                .WithOne(p => p.Atleta);
            builder
                .HasMany(u => u.Categorias)
                .WithOne(p => p.Atleta);

        }
    }
}
