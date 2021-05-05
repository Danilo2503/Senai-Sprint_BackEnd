using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Domains
{
    public partial class Clinica 
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdClinica { get; set; }

        [Required]
        public string NomeFantasia { get; set; }

        [Required]
        public int Cnpj { get; set; }

        [Required]
        public string HroFuncionamento { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string RazaoSocial { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}

