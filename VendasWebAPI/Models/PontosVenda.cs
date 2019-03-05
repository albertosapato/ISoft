using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class PontosVenda
    {
        public PontosVenda()
        {
            PlanoNecessidadeOrdems = new HashSet<PlanoNecessidadeOrdems>();
            TransferenciasArmazemOrdems = new HashSet<TransferenciasArmazemOrdems>();
        }

        public int PontosVendaId { get; set; }
        public string PontosVendaNome { get; set; }
        public int Departamento { get; set; }

        public virtual ICollection<PlanoNecessidadeOrdems> PlanoNecessidadeOrdems { get; set; }
        public virtual ICollection<TransferenciasArmazemOrdems> TransferenciasArmazemOrdems { get; set; }
    }
}
