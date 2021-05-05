using senai.spmedicalgroup.webApi_DBFirst.Contexts;
using senai.spmedicalgroup.webApi_DBFirst.Domains;
using senai.spmedicalgroup.webApi_DBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Repositories
{
    public class PacienteRepository :IPacienteRepository
    {
        MedicalGroupContext ctx = new MedicalGroupContext();
        public void Atualizar(int id, Paciente pacienteAtualizado)
        {
            Paciente pacienteBuscado = ctx.Pacientes.Find(id);

            if (pacienteBuscado.NomePaciente != null)
            {
                pacienteBuscado.NomePaciente = pacienteAtualizado.NomePaciente;
            }

            ctx.Pacientes.Update(pacienteBuscado);

            ctx.SaveChanges();
        }

        public void Cadastrar(Paciente novoPaciente)
        {
            ctx.Pacientes.Add(novoPaciente);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Paciente pacienteBuscado = ctx.Pacientes.Find(id);

            ctx.Pacientes.Remove(pacienteBuscado);

            ctx.SaveChanges();
        }

        public List<Paciente> ListarTodos()
        {
            return ctx.Pacientes.ToList();
        }
    }
}

