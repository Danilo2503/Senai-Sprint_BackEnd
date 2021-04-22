using senai_InLock_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_InLock_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Valida o usuario
        /// </summary>
        /// <param name="email">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns>Um objeto do tipo usuarioDomain que foi buscado</returns>
        UsuarioDomain BuscarPorEmailSenha(string email, string senha);
    }
}
