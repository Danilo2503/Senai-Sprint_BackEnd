using senai.spmedicalgroup.webApi_DBFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Interfaces
{
    interface IEspecialidadeRepository
    {
        List<Especialidade> ListarTodos();

        void Cadastrar(Especialidade novaEspecialidade);

        void Atualizar(int id, Especialidade especialidadeAtualizada);

        void Deletar(int id);
    }
}
