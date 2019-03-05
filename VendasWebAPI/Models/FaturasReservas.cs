using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class FaturasReservas
    {
        public FaturasReservas()
        {
            FaturasOrdemReservas = new HashSet<FaturasOrdemReservas>();
        }

        public string FaturasNumero { get; set; }
        public int FaturasId { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataEntrega { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal SubTotal { get; set; }
        public int ClienteId { get; set; }
        public int UsuariosId { get; set; }
        public decimal Vacrescido { get; set; }
        public decimal UltimoValor { get; set; }
        public decimal Vrestante { get; set; }
        public int Nparcelas { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<FaturasOrdemReservas> FaturasOrdemReservas { get; set; }
    }
}
