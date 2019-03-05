using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class ProdutosStock
    {
        public int ProdutosStockId { get; set; }
        public int QuantidadeCaixa { get; set; }
        public int QuantidadeCadaCaixa { get; set; }
        public int QuantidadeDesponivel { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal ImpostoConsumo { get; set; }
        public decimal PrecoTotal { get; set; }
        public bool Gastavel { get; set; }
        public DateTime Data { get; set; }
        public decimal Custos { get; set; }
        public bool Garantia { get; set; }
        public int Meses { get; set; }
        public string Metodo { get; set; }
        public int ProdutoId { get; set; }
        public int Desconto { get; set; }
        public decimal PrecoVenda2 { get; set; }
        public decimal PrecoTotal2 { get; set; }
        public int Reservado { get; set; }
        public bool Promocoes { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
