using senai.spmedicalgroup.webApi_DBFirst.Contexts;
using senai.spmedicalgroup.webApi_DBFirst.Domains;
using senai.spmedicalgroup.webApi_DBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        MedicalGroupContext ctx = new MedicalGroupContext();
        public void Atualizar(int id, Medico medicoAtualizado)
        {
            Medico medicoBuscado = ctx.Medicos.Find(id);

            if (medicoBuscado.NomeMedico != null || medicoBuscado.Crm != null || medicoBuscado.IdClinica != null || medicoBuscado.IdEspecialidade != null)
            {
                medicoBuscado.NomeMedico = medicoAtualizado.NomeMedico;
                medicoBuscado.Crm = medicoAtualizado.Crm;
                medicoBuscado.IdClinica = medicoAtualizado.IdClinica;
                medicoBuscado.IdEspecialidade = medicoAtualizado.IdEspecialidade;
            }

            ctx.Medicos.Update(medicoBuscado);

            ctx.SaveChanges();
        }

        public void Cadastrar(Medico novoMedico)
        {
            ctx.Medicos.Add(novoMedico);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Medico medicoBuscado = ctx.Medicos.Find(id);

            ctx.Medicos.Remove(medicoBuscado);

            ctx.SaveChanges();
        }

        public List<Medico> ListarTodos()
        {
            return ctx.Medicos.ToList();
        }
    }
}

