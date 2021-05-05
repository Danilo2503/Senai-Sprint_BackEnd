using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webApi_DBFirst.Domains
{
    public partial class StatusConsulta
    {
        public StatusConsulta()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdStatusConsulta { get; set; }
        public string DescricaoStatus { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
}
