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
    public class EsporteController : Controller
    {
        private readonly IEsporteRepository _esporteRepository;
        public EsporteController(IEsporteRepository esporteRepository)
        {
            _esporteRepository = esporteRepository;
        }
        public IActionResult Get()
        {
            try
            {
                return Ok(_esporteRepository.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody]Esporte esporte)
        {
            try
            {
                _esporteRepository.Adicionar(esporte);
                return Created("api/esporte", esporte);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
