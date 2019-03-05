using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class UsuariosEstados
    {
        public int UsuariosEstadosId { get; set; }
        public bool Estado { get; set; }
        public DateTime DataHoras { get; set; }
        public int UsuariosId { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
