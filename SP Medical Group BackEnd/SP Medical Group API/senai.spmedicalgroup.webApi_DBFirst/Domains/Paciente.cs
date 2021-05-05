using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Domains
{
    public partial class Paciente
    {
        public Paciente()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdPaciente { get; set; }
        public int? IdUsuario { get; set; }

        [Required]
        public string NomePaciente { get; set; }

        [Required]
        public int Rg { get; set; }

        [Required]
        public int Cpf { get; set; }

        [Required]
        public string DataNascimento { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}

