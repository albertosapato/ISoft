using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class UsuariosCartaos
    {
        public int UsuariosCartaoId { get; set; }
        public string UsuariosNumero { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Validade { get; set; }
        public int UsuariosId { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
