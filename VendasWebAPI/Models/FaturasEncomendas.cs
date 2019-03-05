using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class FaturasEncomendas
    {
        public FaturasEncomendas()
        {
            FaturasOrdemEncomendas = new HashSet<FaturasOrdemEncomendas>();
        }

        public string FaturasNumero { get; set; }
        public int FaturasEncomendasId { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataEntrega { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal SubTotal { get; set; }
        public int? ClienteId { get; set; }
        public int? UsuariosId { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<FaturasOrdemEncomendas> FaturasOrdemEncomendas { get; set; }
    }
}
