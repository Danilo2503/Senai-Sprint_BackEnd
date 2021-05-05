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
    public class TiposUsuarioController : Controller
    {
        private ITipoUsuariosRepository tiposUsuariosRepository { get; set; }

        public TiposUsuarioController()
        {
            tiposUsuariosRepository = new TiposUsuarioRepository();
        }

        /// <summary>
        /// Método Get irá listar todos os tipos de usuários cadastrados
        /// </summary>
        /// <returns>Lista de objetos em JSON, caso de tudo certo retorna um Ok - 202</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(tiposUsuariosRepository.ListarTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método POST possibilita o cadastro de usuários no sistema via JSON
        /// </summary>
        /// <param name="novoTipoUsuario">Parâmentro que armazena todas as informações de Tipos de usuários</param>
        /// <returns>Irá retornar um StatusCode - 202</returns>
        [HttpPost]
        public IActionResult Post(TiposUsuario novoTipoUsuario)
        {
            try
            {
                tiposUsuariosRepository.Cadastrar(novoTipoUsuario);

                return StatusCode(202);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método Put permite a atualilzação de Tipos de Usuáriuos 
        /// </summary>
        /// <param name="id">Parâmetro utilizado para encontrar o usuário</param>
        /// <param name="tiposUsuariosAtualizado">Um novo objeto que irá armazenar as novas informações cadastradas</param>
        /// <returns>Irá retornar o objeto atualizado com o StatusCode de 204</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, TiposUsuario tiposUsuariosAtualizado)
        {
            try
            {
                tiposUsuariosRepository.Atualizar(id, tiposUsuariosAtualizado);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método Delete proporciona a exclusão de um tipo de usuário já existente 
        /// </summary>
        /// <param name="id">Parâmentro utilizados para encontrar o usuário em questão</param>
        /// <returns>Deleta o usuário e retorna um StatusCode - 204</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                tiposUsuariosRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}

