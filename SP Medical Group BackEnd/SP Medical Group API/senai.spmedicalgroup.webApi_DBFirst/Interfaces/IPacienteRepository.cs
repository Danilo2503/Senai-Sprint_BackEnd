using senai.spmedicalgroup.webApi_DBFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Interfaces
{
    interface IPacienteRepository
    {
        List<Paciente> ListarTodos();

        void Cadastrar(Paciente novoPaciente);

        void Atualizar(int id, Paciente pacienteAtualizado);

        void Deletar(int id);
    }
}
