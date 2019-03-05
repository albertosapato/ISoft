using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class FPagamento
    {
        public FPagamento()
        {
            Fatura = new HashSet<Fatura>();
            FaturasArmazem = new HashSet<FaturasArmazem>();
        }

        public int FpagamentoId { get; set; }
        public string Fpagamento1 { get; set; }
        public bool Dividas { get; set; }
        public int? Dias { get; set; }
        public bool Particionar { get; set; }
        public bool Banco { get; set; }
        public bool Fisico { get; set; }

        public virtual ICollection<Fatura> Fatura { get; set; }
        public virtual ICollection<FaturasArmazem> FaturasArmazem { get; set; }
    }
}
