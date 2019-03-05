using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Departamentos
    {
        public Departamentos()
        {
            Caixa = new HashSet<Caixa>();
            CaixaAnual = new HashSet<CaixaAnual>();
            Categoria = new HashSet<Categoria>();
            Clientes = new HashSet<Clientes>();
            Definicoes = new HashSet<Definicoes>();
            Fornecedor = new HashSet<Fornecedor>();
            Grupos = new HashSet<Grupos>();
            Produto = new HashSet<Produto>();
            ProdutosSugestao = new HashSet<ProdutosSugestao>();
        }

        public int DepartamentoId { get; set; }
        public string DepartamentoNome { get; set; }
        public string Localizacao { get; set; }
        public int ProvinciaId { get; set; }
        public int DivisaoId { get; set; }

        public virtual Divisao Divisao { get; set; }
        public virtual Provincias Provincia { get; set; }
        public virtual ICollection<Caixa> Caixa { get; set; }
        public virtual ICollection<CaixaAnual> CaixaAnual { get; set; }
        public virtual ICollection<Categoria> Categoria { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Definicoes> Definicoes { get; set; }
        public virtual ICollection<Fornecedor> Fornecedor { get; set; }
        public virtual ICollection<Grupos> Grupos { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
        public virtual ICollection<ProdutosSugestao> ProdutosSugestao { get; set; }
    }
}
