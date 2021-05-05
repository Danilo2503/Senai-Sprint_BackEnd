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
    public class PacienteController : Controller
    {
        private IPacienteRepository pacienteRepository { get; set; }

        public PacienteController()
        {
            pacienteRepository = new PacienteRepository();
        }

        /// <summary>
        /// Método GET nos lista os pacientes que estão cadastrados na Banco de dados
        /// </summary>
        /// <returns>Retorna uma lista de pacientes e um StatusCode quando tudo funciona corretamente</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(pacienteRepository.ListarTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        ///<summary>
        ///Método POST nos permite cadastrar um novo paciente preenchendo todos os seus dados
        /// </summary>
        /// <returns>Retorna um StatusCode no caso de tudo dar certo</returns>
        [HttpPost]
        public IActionResult Post(Paciente novoPaciente)
        {
            try
            {
                pacienteRepository.Cadastrar(novoPaciente);

                return StatusCode(202);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        /// <summary>
        /// Método PUT nos permite Atualizar os dados dos pacientes cadastrados no Banco de dados
        /// </summary>
        /// <param name="id">Parâmetro utilizado para encontrar o paciente desejado</param>
        /// <param name="pacienteAtualizado">Objeto que irá armazenar as novas informações dos pacientes</param>
        /// <returns>Retorna um StatusCode 204 quando tudo funciona</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Paciente pacienteAtualizado)
        {
            try
            {
                pacienteRepository.Atualizar(id, pacienteAtualizado);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método DELETE permite o adminitrados do sistema a excluir qualquer paciente cadastrado no sistema
        /// </summary>
        /// <param name="id">Parâmetro utilizado para encontrar o paciente desejado</param>
        /// <returns>Exclui o Paciente em questão e retorna um StatusCode - 204 caso tudo funcione corretamente</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                pacienteRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}

