using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Domains
{
    public partial class Consulta
    {
        public int IdConsulta { get; set; }
        public int? IdPaciente { get; set; }

        [Required]
        public int? IdMedico { get; set; }
        public int? IdStatusConsulta { get; set; }

        [Required]
        public string DataConsulta { get; set; }

        [Required]
        public string HroConsulta { get; set; }

        [Required]
        public string DescricaoConsulta { get; set; }

        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual StatusConsulta IdStatusConsultaNavigation { get; set; }
    }
}

