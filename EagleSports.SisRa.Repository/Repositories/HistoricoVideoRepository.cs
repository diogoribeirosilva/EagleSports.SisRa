using EagleSports.SisRa.Domain.Entities;
using EagleSports.SisRa.Domain.Interfaces;
using EagleSports.SisRa.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EagleSports.SisRa.Repository.Repositories
{
    public class HistoricoVideoRepository : BaseRepository<HistoricoVideo>, IHistoricoVideoRepository
    {
        public HistoricoVideoRepository(SisRaContext sisRaContext) : base(sisRaContext)
        {
        }
    }
}
