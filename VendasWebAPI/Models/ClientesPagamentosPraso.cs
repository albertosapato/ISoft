using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class ClientesPagamentosPraso
    {
        public int ClientesPagamentosPrasoId { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public string RegistoPagamento { get; set; }
        public decimal PagamentoParcelar { get; set; }
        public decimal PagamentoGeral { get; set; }
        public bool Estado { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
