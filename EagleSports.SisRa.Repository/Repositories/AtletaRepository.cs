using EagleSports.SisRa.Domain.Entities;
using EagleSports.SisRa.Domain.Interfaces;
using EagleSports.SisRa.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Repository.Repositories
{
    public class AtletaRepository : BaseRepository<Atleta>, IAtletaRepository
    {
        public AtletaRepository(SisRaContext sisRaContext) : base(sisRaContext)
        {
        }
    }
}
