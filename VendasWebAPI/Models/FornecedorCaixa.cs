using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class FornecedorCaixa
    {
        public int FornecedorCaixaId { get; set; }
        public decimal Vcreditar { get; set; }
        public decimal Vdebitar { get; set; }
        public DateTime Data { get; set; }
        public int FornecedorId { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
    }
}
