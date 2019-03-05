using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class ProdutosStockHistorico
    {
        public int ProdutosStockHistoricoId { get; set; }
        public int QuantidadeDesponivel { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoTotal { get; set; }
        public DateTime Data { get; set; }
        public int ProdutoId { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
