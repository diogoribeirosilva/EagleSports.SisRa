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
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public IActionResult Get()
        {
            try
            {
                return Ok(_categoriaRepository.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody]Categoria Categoria)
        {
            try
            {
                _categoriaRepository.Adicionar(Categoria);
                return Created("api/esporte", Categoria);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
