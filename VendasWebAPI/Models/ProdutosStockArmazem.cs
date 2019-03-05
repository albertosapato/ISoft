using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class ProdutosStockArmazem
    {
        public int ProdutosStockArmazemId { get; set; }
        public int QuantidadeDesponivel { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoTotal { get; set; }
        public bool Gastavel { get; set; }
        public DateTime Data { get; set; }
        public int ProdutoId { get; set; }
        public int? ProdutosStockArmazemEstadosId { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual ProdutosStockArmazemEstados ProdutosStockArmazemEstados { get; set; }
    }
}
