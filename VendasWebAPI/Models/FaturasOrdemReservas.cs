using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class FaturasOrdemReservas
    {
        public int FaturasOrdemId { get; set; }
        public string FaturasNumero { get; set; }
        public int? Quantidade { get; set; }
        public decimal? PrecoUnitario { get; set; }
        public decimal? ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public int ProdutoId { get; set; }

        public virtual FaturasReservas FaturasNumeroNavigation { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
