using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class FaturasProformas
    {
        public FaturasProformas()
        {
            FaturasOrdemProformas = new HashSet<FaturasOrdemProformas>();
        }

        public string FaturasNumero { get; set; }
        public int FaturasId { get; set; }
        public DateTime? Data { get; set; }
        public TimeSpan? Hora { get; set; }
        public decimal? SubTotal { get; set; }
        public int? ClienteId { get; set; }
        public int? UsuariosId { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<FaturasOrdemProformas> FaturasOrdemProformas { get; set; }
    }
}
