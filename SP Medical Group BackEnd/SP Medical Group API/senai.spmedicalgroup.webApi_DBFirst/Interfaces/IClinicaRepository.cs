using senai.spmedicalgroup.webApi_DBFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Interfaces
{
    interface IClinicaRepository
    {
        List<Clinica> ListarTodos();

        void Cadastrar(Clinica novaClinica);

        void Atualizar(int id, Clinica clinicaAtualizada);

        void Deletar(int id);
    }
}
