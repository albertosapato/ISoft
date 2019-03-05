using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            FornecedorCaixa = new HashSet<FornecedorCaixa>();
            Produto = new HashSet<Produto>();
        }

        public int FornecedorId { get; set; }
        public string FornecedorNome { get; set; }
        public string Nif { get; set; }
        public string Contacto { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string RuaLocalidade { get; set; }
        public string Notas { get; set; }
        public int ProvinciaId { get; set; }
        public int DepartamentoId { get; set; }

        public virtual Departamentos Departamento { get; set; }
        public virtual Provincias Provincia { get; set; }
        public virtual ICollection<FornecedorCaixa> FornecedorCaixa { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
}
