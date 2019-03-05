using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Grupos
    {
        public Grupos()
        {
            Permissoes = new HashSet<Permissoes>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int GrupoId { get; set; }
        public string GrupoNome { get; set; }
        public string GrupoComentarios { get; set; }
        public int DepartamentoId { get; set; }

        public virtual Departamentos Departamento { get; set; }
        public virtual ICollection<Permissoes> Permissoes { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
