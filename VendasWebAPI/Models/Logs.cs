using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Logs
    {
        public int LogsId { get; set; }
        public DateTime Data { get; set; }
        public string Operacao { get; set; }
        public TimeSpan Hora { get; set; }
        public int UsuariosId { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
