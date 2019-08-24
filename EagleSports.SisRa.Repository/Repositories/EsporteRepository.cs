using EagleSports.SisRa.Domain.Entities;
using EagleSports.SisRa.Domain.Interfaces;
using EagleSports.SisRa.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Repository.Repositories
{
    public class EsporteRepository : BaseRepository<Esporte>, IEsporteRepository
    {
        public EsporteRepository(SisRaContext sisRaContext) : base(sisRaContext)
        {
        }
    }
}
