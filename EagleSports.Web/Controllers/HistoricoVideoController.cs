using EagleSports.SisRa.Domain.Entities;
using EagleSports.SisRa.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EagleSports.Web.Controllers
{
    [Route("api/[Controller]")]
    public class HistoricoVideoController : Controller
    {
        private readonly IHistoricoVideoRepository _historicoVideoRepository;
        public HistoricoVideoController(IHistoricoVideoRepository historicoVideoRepository)
        {
            _historicoVideoRepository = historicoVideoRepository;
               
        }
        public IActionResult Get()
        {
            try
            {
                return Ok(_historicoVideoRepository.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody]HistoricoVideo historicoVideo)
        {
            try
            {
                _historicoVideoRepository.Adicionar(historicoVideo);
                return Created("api/esporte", historicoVideo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
