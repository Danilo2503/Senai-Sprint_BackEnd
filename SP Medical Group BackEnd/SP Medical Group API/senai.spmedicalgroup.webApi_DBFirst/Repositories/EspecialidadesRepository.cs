using senai.spmedicalgroup.webApi_DBFirst.Contexts;
using senai.spmedicalgroup.webApi_DBFirst.Domains;
using senai.spmedicalgroup.webApi_DBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Repositories
{
    public class EspecialidadesRepository : IEspecialidadeRepository
    {
        MedicalGroupContext ctx = new MedicalGroupContext();
        public void Atualizar(int id, Especialidade especialidadeAtualizada)
        {
            Especialidade especialidadeBuscado = ctx.Especialidades.Find(id);

            if (especialidadeBuscado.DescricaoEspec != null)
            {
                especialidadeBuscado.DescricaoEspec = especialidadeAtualizada.DescricaoEspec;
            }

            ctx.Especialidades.Update(especialidadeBuscado);

            ctx.SaveChanges();
        }

        public void Cadastrar(Especialidade novaEspecialidade)
        {
            ctx.Especialidades.Add(novaEspecialidade);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Especialidade especialidadeBuscado = ctx.Especialidades.Find(id);

            ctx.Especialidades.Remove(especialidadeBuscado);

            ctx.SaveChanges();
        }

        public List<Especialidade> ListarTodos()
        {
            return ctx.Especialidades.ToList();
        }
    }
}

