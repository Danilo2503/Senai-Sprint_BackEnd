using senai.spmedicalgroup.webApi_DBFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Interfaces
{
    interface IConsultaRepository
    {
        List<Consulta> ListarTodos();

        void Cadastrar(Consulta novaConsulta);

        void Atualizar(int id, Consulta consultaAtualizada);

        void Deletar(int id);
    }
}
