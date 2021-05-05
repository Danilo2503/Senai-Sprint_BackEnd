using Microsoft.AspNetCore.Mvc;
using senai.spmedicalgroup.webApi_DBFirst.Domains;
using senai.spmedicalgroup.webApi_DBFirst.Interfaces;
using senai.spmedicalgroup.webApi_DBFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicaController : Controller
    {
        private IClinicaRepository clinicaRepository { get; set; }

        public ClinicaController()
        {
            clinicaRepository = new ClinicaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(clinicaRepository.ListarTodos());

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post(Clinica novaClincia)
        {
            try
            {
                clinicaRepository.Cadastrar(novaClincia);

                return StatusCode(202);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Clinica clinicaAtualizada)
        {
            try
            {
                clinicaRepository.Atualizar(id, clinicaAtualizada);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                clinicaRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
