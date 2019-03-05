using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class CaixaResumo
    {
        public int CaixaResumoId { get; set; }
        public DateTime Data { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoRemover { get; set; }
        public decimal SaldoFinal { get; set; }
        public string Operacao { get; set; }
        public int CaixaAnualId { get; set; }
        public string Explicao { get; set; }

        public virtual CaixaAnual CaixaAnual { get; set; }
    }
}
