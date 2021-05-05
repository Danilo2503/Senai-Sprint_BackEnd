using senai.spmedicalgroup.webApi_DBFirst.Contexts;
using senai.spmedicalgroup.webApi_DBFirst.Domains;
using senai.spmedicalgroup.webApi_DBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        MedicalGroupContext ctx = new MedicalGroupContext();
        public void Atualizar(int id, Clinica clinicaAtualizada)
        {
            Clinica clinicaDesejada = ctx.Clinicas.Find(id);

            if (clinicaDesejada.NomeFantasia != null || clinicaDesejada.RazaoSocial != null || clinicaDesejada.Endereco != null || clinicaDesejada.Cnpj != 0 || clinicaDesejada.HroFuncionamento != null)
            {
                clinicaDesejada.NomeFantasia = clinicaAtualizada.NomeFantasia;
                clinicaDesejada.RazaoSocial = clinicaAtualizada.RazaoSocial;
                clinicaDesejada.Endereco = clinicaAtualizada.Endereco;
                clinicaDesejada.Cnpj = clinicaAtualizada.Cnpj;
                clinicaDesejada.HoraFuncionamento = clinicaAtualizada.HroFuncionamento;
            }

            ctx.Clinicas.Update(clinicaDesejada);

            ctx.SaveChanges();
        }

        public void Cadastrar(Clinica novaClinica)
        {
            ctx.Clinicas.Add(novaClinica);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Clinica clinicaBuscada = ctx.Clinicas.Find(id);

            ctx.Clinicas.Remove(clinicaBuscada);

            ctx.SaveChanges();
        }

        public List<Clinica> ListarTodos()
        {
            return ctx.Clinicas.ToList();
        }
    }
}

