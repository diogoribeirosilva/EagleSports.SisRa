using EagleSports.SisRa.Domain.Entities;
using EagleSports.SisRa.Domain.Interfaces;
using EagleSports.SisRa.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EagleSports.Web.Controllers
{
    [Route("api/[Controller]")]
    public class AtletaController : Controller
    {
        private readonly IAtletaRepository _atletaRepository;
        public AtletaController(IAtletaRepository atletaRepository)
        {
            _atletaRepository = atletaRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_atletaRepository.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody]Atleta atleta)
        {
            try
            {
                _atletaRepository.Adicionar(atleta);
                return Created("api/atleta", atleta);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
