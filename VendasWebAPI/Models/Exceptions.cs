using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Exceptions
    {
        public int ExceptionId { get; set; }
        public string Formulario { get; set; }
        public string Metodo { get; set; }
        public string Erro { get; set; }
        public DateTime DataHoras { get; set; }
        public int? UsuariosId { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
