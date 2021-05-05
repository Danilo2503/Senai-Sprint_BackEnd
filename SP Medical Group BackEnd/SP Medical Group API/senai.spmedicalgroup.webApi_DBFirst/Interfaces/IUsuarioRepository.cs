using senai.spmedicalgroup.webApi_DBFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista de usuários cadastrados
        /// </summary>
        /// <returns>Retornar uma lista com os usuários cadastrados no banco de dados</returns>
        List<Usuario> ListarTodos();

        /// <summary>
        /// Criação de um novo usuário no banco de dados
        /// </summary>
        /// <param name="novoUsuario">Novo usuário cadastrado</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Atualizar um usuário já existente
        /// </summary>
        /// <param name="id">Id para identificação dos usuários</param>
        /// <param name="usuarioAtualizado">váriavel que irá conter a alteração desejada</param>
        /// <returns>Irá retornar um objeto com o usuário alterado</returns>
        void Atualizar(int id, Usuario usuarioAtualizado);

        /// <summary>
        /// Método irá deletar um usuário informado pelo id
        /// </summary>
        /// <param name="id">id que será utilizado para a identificação do usuário</param>
        void Deletar(int id);
    }
}
