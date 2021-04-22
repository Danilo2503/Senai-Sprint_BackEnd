using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_InLock_webApi.Domains;
using senai_InLock_webApi.Interfaces;
using senai_InLock_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_InLock_webApi.Controllers
{
    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato: dominio/api/NomeDoController
    // Exemplo: http://localhost:5000/api/estudios
    [Route("api/[controller]")]

    // Define que é um controller de API
    [ApiController]
    public class EstudioController : ControllerBase
    {
        /// <summary>
        /// Objeto que recebe os métodos definidos na interface IEstudioRepository
        /// </summary>

        private IEstudioRepository _EstudioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _EstudioRepository para referenciar os métodos no repositório
        /// </summary>

        public EstudioController()
        {
            _EstudioRepository = new EstudioRepository();
        }


        /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns>Um status code 200(ok) junto com as informações dos estúdios</returns>
        // [Authorize(Roles = "1, 2")]
        [HttpGet]
        public IActionResult ListarEstudios()
        {
            // Cria uma lista de estúdios e seus respectivos jogos
            List<EstudioDomain> estudios = _EstudioRepository.ListarTodos();

            // Retorna um status code 200(ok) junto com as informações dos estudios
            return Ok(estudios);
        }


    }
}

