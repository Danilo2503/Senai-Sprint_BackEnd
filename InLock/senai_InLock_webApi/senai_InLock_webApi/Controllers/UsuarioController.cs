using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai_InLock_webApi.Domains;
using senai_InLock_webApi.Interfaces;
using senai_InLock_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai_InLock_webApi.Controllers
{
    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato: dominio/api/NomeDoController
    // Exemplo: http://localhost:5000/api/usuaario
    [Route("api/[controller]")]

    // Define que é um controller de API
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /// <summary>
        /// Objeto que recebe os métodos definidos na interface IUsuarioRepository
        /// </summary>
        private IUsuarioRepository _UsuarioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _UsuarioRepository para referenciar os métodos no repositório
        /// </summary>
        public UsuarioController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }


        [HttpPost("login")]
        public IActionResult Login(UsuarioDomain usuario)
        {
            // Usuario com as informações de acordo com o email e senha passados
            UsuarioDomain usuarioLogin = _UsuarioRepository.BuscarPorEmailSenha(usuario.email, usuario.senha);

            // Caso não encontre nenhum usuário com o email e senha informados:
            if (usuarioLogin == null)
            {
                // Retorne NotFound com uma mensagem personalizada
                return NotFound("E-mail ou senha inválidos!");
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, usuarioLogin.email),
                new Claim(JwtRegisteredClaimNames.Jti, usuarioLogin.idUsuario.ToString()),
                new Claim(ClaimTypes.Role, usuarioLogin.idTipoUsuario.ToString()),
            };

            // Define a chave de acesso ao token
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("inlock-chave-de-acesso"));

            // Define as credenciais do token (header)
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Define a composição do token
            var token = new JwtSecurityToken(
                issuer: "InLock_Games",                 // Emissor do token
                audience: "InLock_Games",               // Receptor do token
                claims: claims,                         // Informações do usuário
                expires: DateTime.Now.AddMinutes(5),    // Tempo de expiração
                signingCredentials: creds               // Credenciais do token
            );

            // Retorna um status code Ok(200) com o token criado
            return Ok(new
            {
                // Gera o token com base nas informações definidas anteriormente e retorna junto com o status code
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }
    }
}

