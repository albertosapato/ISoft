using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class TransferenciasArmazems
    {
        public TransferenciasArmazems()
        {
            TransferenciasArmazemOrdems = new HashSet<TransferenciasArmazemOrdems>();
        }

        public string Referencia { get; set; }
        public int TransferenciasArmazemId { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public bool Estado { get; set; }
        public int QtdTotal { get; set; }
        public decimal Vtotal { get; set; }

        public virtual ICollection<TransferenciasArmazemOrdems> TransferenciasArmazemOrdems { get; set; }
    }
}
