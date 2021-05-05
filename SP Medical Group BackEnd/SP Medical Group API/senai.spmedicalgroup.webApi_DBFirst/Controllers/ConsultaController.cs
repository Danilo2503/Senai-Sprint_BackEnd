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
    public class ConsultaController : Controller
    {
        private IConsultaRepository consultaRepository { get; set; }

        public ConsultaController()
        {
            consultaRepository = new ConsultasRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(consultaRepository.ListarTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post(Consulta novaConsulta)
        {
            try
            {
                consultaRepository.Cadastrar(novaConsulta);

                return StatusCode(202);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Consulta consultaAtualizada)
        {
            try
            {
                consultaRepository.Atualizar(id, consultaAtualizada);

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
                consultaRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}

