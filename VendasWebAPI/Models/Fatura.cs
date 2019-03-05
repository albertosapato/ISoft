using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Fatura
    {
        public Fatura()
        {
            FaturasOrdems = new HashSet<FaturasOrdems>();
            Pedidos = new HashSet<Pedidos>();
        }

        public string FaturasNumero { get; set; }
        public int FaturasId { get; set; }
        public DateTime? Data { get; set; }
        public TimeSpan? Hora { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Porc1Desc { get; set; }
        public decimal? Parc2DescPerc { get; set; }
        public decimal? GrandeTotal { get; set; }
        public decimal? ValorPago { get; set; }
        public decimal? ValorPagoTroco { get; set; }
        public decimal GrandeTotalFisico { get; set; }
        public decimal GrandeTotalBanco { get; set; }
        public int ClienteId { get; set; }
        public int UsuariosId { get; set; }
        public int FpagamentoId { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual FPagamento Fpagamento { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<FaturasOrdems> FaturasOrdems { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
