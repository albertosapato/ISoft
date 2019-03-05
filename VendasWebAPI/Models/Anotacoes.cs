using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Anotacoes
    {
        public int AnotacoesId { get; set; }
        public string AnotacoesNome { get; set; }
        public string Referencia { get; set; }
        public DateTime Data { get; set; }
        public int UsuariosId { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
