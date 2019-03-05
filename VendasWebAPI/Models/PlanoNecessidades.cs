using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class PlanoNecessidades
    {
        public PlanoNecessidades()
        {
            PlanoNecessidadeOrdems = new HashSet<PlanoNecessidadeOrdems>();
        }

        public string Referencia { get; set; }
        public int PlanoNecessidadeId { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public bool Estado { get; set; }
        public int QtdTotal { get; set; }

        public virtual ICollection<PlanoNecessidadeOrdems> PlanoNecessidadeOrdems { get; set; }
    }
}
