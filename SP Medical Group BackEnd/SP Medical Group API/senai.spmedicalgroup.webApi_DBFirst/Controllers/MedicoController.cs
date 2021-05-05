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
    public class MedicoController : Controller
    {
        private IMedicoRepository medicoRepository { get; set; }

        public MedicoController()
        {
            medicoRepository = new MedicoRepository();
        }

        /// <summary>
        /// Método GET que lista todos os médicos cadastrados no banco de dados
        /// </summary>
        /// <returns>Caso dê tudo certo irá retornar o StatusCode - 201</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(medicoRepository.ListarTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método POST que permite cadastrar novos médicos no Banco de dados
        /// </summary>
        /// <param name="novoMedico"></param>
        /// <returns> Retorna um StatusCode - 202 caso tudo funcione</returns>
        [HttpPost]
        public IActionResult Post(Medico novoMedico)
        {
            try
            {
                medicoRepository.Cadastrar(novoMedico);

                return StatusCode(202);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método POST que permite atualizar as informações dos medicos cadastrados
        /// </summary>
        /// <param name="id">Parâmentro utilizado para identificar os médicos no banco de dados</param>
        /// <param name="medicoAtualizado">Objeto que irá armazenar as novas informações do médico desejado</param>
        /// <returns>Retorna um StatusCode - 204 caso tudo dê certo</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Medico medicoAtualizado)
        {
            try
            {
                medicoRepository.Atualizar(id, medicoAtualizado);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método DELETE permite deletar um médico cadastrado no banco de dados
        /// </summary>
        /// <param name="id">Parâmetro usado para encontrar o médico desejado</param>
        /// <returns>Retorna um StatusCode 204 quando tudo funciona</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                medicoRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}

