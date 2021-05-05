using senai.spmedicalgroup.webApi_DBFirst.Contexts;
using senai.spmedicalgroup.webApi_DBFirst.Domains;
using senai.spmedicalgroup.webApi_DBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Repositories
{
    public class ConsultasRepository : IConsultaRepository
    {
        MedicalGroupContext ctx = new MedicalGroupContext();
        public void Atualizar(int id, Consulta consultaAtualizada)
        {
            Consulta consultaBuscado = ctx.Consultas.Find(id);

            if (consultaBuscado.DescricaoConsulta != null || consultaBuscado.DataConsulta != null || consultaBuscado.HroConsulta != null || consultaBuscado.IdStatusConsulta != null)
            {
                consultaBuscado.DescricaoConsulta = consultaAtualizada.DescricaoConsulta;
                consultaBuscado.DataConsulta = consultaAtualizada.DataConsulta;
                consultaBuscado.HroConsulta = consultaAtualizada.HroConsulta;
                consultaBuscado.IdStatusConsulta = consultaAtualizada.IdStatusConsulta;
            }

            ctx.Consultas.Update(consultaBuscado);

            ctx.SaveChanges();
        }

        public void Cadastrar(Consulta novaConsulta)
        {
            ctx.Consultas.Add(novaConsulta);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Consulta consultaDesejada = ctx.Consultas.Find(id);

            ctx.Consultas.Remove(consultaDesejada);

            ctx.SaveChanges();
        }

        public List<Consulta> ListarTodos()
        {
            return ctx.Consultas.ToList();
        }
    }
}

