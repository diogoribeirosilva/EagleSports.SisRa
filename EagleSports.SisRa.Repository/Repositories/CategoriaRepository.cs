using EagleSports.SisRa.Domain.Entities;
using EagleSports.SisRa.Domain.Interfaces;
using EagleSports.SisRa.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Repository.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(SisRaContext sisRaContext) : base(sisRaContext)
        {
        }
    }
}
