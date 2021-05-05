using senai.spmedicalgroup.webApi_DBFirst.Contexts;
using senai.spmedicalgroup.webApi_DBFirst.Domains;
using senai.spmedicalgroup.webApi_DBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Repositories
{
    public class TiposUsuarioRepository : ITipoUsuariosRepository
    {
        MedicalGroupContext ctx = new MedicalGroupContext();

        public void Atualizar(int id, TiposUsuario tiposUsuarioAtualizado)
        {
            TiposUsuario tipoBuscado = ctx.TiposUsuarios.Find(id);

            if (tipoBuscado.Nome != null)
            {
                tipoBuscado.Nome = tiposUsuarioAtualizado.Nome;
            }

            ctx.TiposUsuarios.Update(tipoBuscado);

            ctx.SaveChanges();
        }

        public void Cadastrar(TiposUsuario novoTipoUsuario)
        {
            ctx.TiposUsuarios.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TiposUsuario tipoBuscado = ctx.TiposUsuarios.Find(id);

            ctx.TiposUsuarios.Remove(tipoBuscado);

            ctx.SaveChanges();
        }

        public List<TiposUsuario> ListarTodos()
        {
            return ctx.TiposUsuarios.ToList();
        }
    }
}

