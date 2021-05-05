using senai.spmedicalgroup.webApi_DBFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Interfaces
{
    interface ITipoUsuariosRepository
    {
        List<TiposUsuario> ListarTodos();

        void Cadastrar(TiposUsuario novoTipoUsuario);

        void Atualizar(int id, TiposUsuario tiposUsuarioAtualizado);

        void Deletar(int id);
    }
}
