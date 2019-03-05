using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Divisao
    {
        public Divisao()
        {
            Departamentos = new HashSet<Departamentos>();
        }

        public int DivisaoId { get; set; }
        public string DivisaoNome { get; set; }
        public string Referencia { get; set; }

        public virtual ICollection<Departamentos> Departamentos { get; set; }
    }
}
