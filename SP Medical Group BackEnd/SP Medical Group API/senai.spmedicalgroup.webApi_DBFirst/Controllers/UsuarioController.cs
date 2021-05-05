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
    public class UsuarioController : Controller
    {
        /// <summary>
        /// O objeto usuarioRepository recebe todos os métodos criados na interface
        /// </summary>
        private IUsuarioRepository usuarioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto usuarioRepository para que haja a referência aos métodos
        /// </summary>
        public UsuarioController()
        {
            usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        ///Lista todos os usuários cadastrados 
        /// </summary>
        /// <returns>Uma lista de usuários e um status code Ok - 200</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //Retorna a resposta da requisição fazendo a chamada para o método listar
                return Ok(usuarioRepository.ListarTodos());
            }
            catch (Exception ex)
            {
                //Retorna a exceção/ erro e trás para o desenvolvedor o erro gerado
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método POST irá cadastrar usuários via JSON com o POSTMAN
        /// </summary>
        /// <param name="novoUsuario">Objeto para instanciar um novo objeto com todas suas propriedades</param>
        /// <returns>Retorna um status code  201 - tudo certo</returns>
        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            try
            {
                usuarioRepository.Cadastrar(novoUsuario);

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Atualiza um usuário já  cadastrado no sistema
        /// </summary>
        /// <param name="id">id utilizado para achar o usuário desejado</param>
        /// <param name="usuarioAtualizado">Objeto para armazenar as novas informações</param>
        /// <returns>Retorna um Satus code informando que tudo ocorreu bem, caso contrário retorna um bad request</returns>
        [HttpPut("{id}")]
        public IActionResult PutAtualizar(int id, Usuario usuarioAtualizado)
        {
            try
            {
                usuarioRepository.Atualizar(id, usuarioAtualizado);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Deleta um usuário já existente no sistema
        /// </summary>
        /// <param name="id">parâmetro usado para encontrar o usuário desejado</param>
        /// <returns>Deleta o usuário desejado caso você tenha permissão , caso contrário gera um BadRequest</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                usuarioRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

    }
}

