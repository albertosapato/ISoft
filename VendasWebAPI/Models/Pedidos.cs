using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Pedidos
    {
        public int PedidosId { get; set; }
        public bool Estado { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Horas { get; set; }
        public string Detalhes { get; set; }
        public string FaturasNumero { get; set; }

        public virtual Fatura FaturasNumeroNavigation { get; set; }
    }
}
