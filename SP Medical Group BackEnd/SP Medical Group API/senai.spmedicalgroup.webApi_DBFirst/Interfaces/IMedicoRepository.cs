using senai.spmedicalgroup.webApi_DBFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Interfaces
{
    interface IMedicoRepository
    {
        List<Medico> ListarTodos();

        void Cadastrar(Medico novoMedico);

        void Atualizar(int id, Medico medicoAtualizado);

        void Deletar(int id);
    }
}
