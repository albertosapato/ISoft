using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class ProdutosAuditoriaArmazem
    {
        public int ProdutosAuditoriaArmazemId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public string Operacao { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public int? QuantidadeStocks { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
