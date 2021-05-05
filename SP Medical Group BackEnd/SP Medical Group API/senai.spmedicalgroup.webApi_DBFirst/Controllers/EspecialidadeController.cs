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
    public class EspecialidadeController : Controller
    {
        private IEspecialidadeRepository especialidadeRepository { get; set; }

        public EspecialidadeController()
        {
            especialidadeRepository = new EspecialidadesRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(especialidadeRepository.ListarTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post(Especialidade novaEspecialidade)
        {
            try
            {
                especialidadeRepository.Cadastrar(novaEspecialidade);

                return StatusCode(202);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Especialidade especialidadeAtualizada)
        {
            try
            {
                especialidadeRepository.Atualizar(id, especialidadeAtualizada);

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
                especialidadeRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}

