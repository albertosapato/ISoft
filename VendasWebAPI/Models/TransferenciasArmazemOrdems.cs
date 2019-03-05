using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class TransferenciasArmazemOrdems
    {
        public int TransferenciasArmazemOrdemId { get; set; }
        public string Referencia { get; set; }
        public int QuantidadeInicial { get; set; }
        public int QuantidadeTransferida { get; set; }
        public int QuantidadeDesponivel { get; set; }
        public decimal PrecoInicial { get; set; }
        public decimal PrecoTotal { get; set; }
        public int PontosVendaId { get; set; }
        public int ProdutoId { get; set; }

        public virtual PontosVenda PontosVenda { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual TransferenciasArmazems ReferenciaNavigation { get; set; }
    }
}
