using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Produto
    {
        public Produto()
        {
            ClientesPagamentosPraso = new HashSet<ClientesPagamentosPraso>();
            FaturasOrdemArmazem = new HashSet<FaturasOrdemArmazem>();
            FaturasOrdemEncomendas = new HashSet<FaturasOrdemEncomendas>();
            FaturasOrdemProformas = new HashSet<FaturasOrdemProformas>();
            FaturasOrdemReservas = new HashSet<FaturasOrdemReservas>();
            FaturasOrdems = new HashSet<FaturasOrdems>();
            PlanoNecessidadeOrdems = new HashSet<PlanoNecessidadeOrdems>();
            ProdutoAuditoria = new HashSet<ProdutoAuditoria>();
            ProdutosAuditoriaArmazem = new HashSet<ProdutosAuditoriaArmazem>();
            ProdutosEsquivalencia = new HashSet<ProdutosEsquivalencia>();
            ProdutosStockArmazem = new HashSet<ProdutosStockArmazem>();
            ProdutosStockHistorico = new HashSet<ProdutosStockHistorico>();
            TransferenciasArmazemOrdems = new HashSet<TransferenciasArmazemOrdems>();
        }

        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public string Pratileira { get; set; }
        public string Comentarios { get; set; }
        public decimal PrecoCompra { get; set; }
        public string CodigoBarra { get; set; }
        public byte[] Imagem { get; set; }
        public string ImagemServer { get; set; }
        public string UnidadeMedida { get; set; }
        public string Fabricante { get; set; }
        public string Marca { get; set; }
        public DateTime ProdutoValidade1 { get; set; }
        public DateTime ProdutoValidade2 { get; set; }
        public int DepartamentoId { get; set; }
        public int SubCategoriaId { get; set; }
        public int FornecedorId { get; set; }

        public virtual Departamentos Departamento { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual SubCategoria SubCategoria { get; set; }
        public virtual ProdutosStock ProdutosStock { get; set; }
        public virtual ICollection<ClientesPagamentosPraso> ClientesPagamentosPraso { get; set; }
        public virtual ICollection<FaturasOrdemArmazem> FaturasOrdemArmazem { get; set; }
        public virtual ICollection<FaturasOrdemEncomendas> FaturasOrdemEncomendas { get; set; }
        public virtual ICollection<FaturasOrdemProformas> FaturasOrdemProformas { get; set; }
        public virtual ICollection<FaturasOrdemReservas> FaturasOrdemReservas { get; set; }
        public virtual ICollection<FaturasOrdems> FaturasOrdems { get; set; }
        public virtual ICollection<PlanoNecessidadeOrdems> PlanoNecessidadeOrdems { get; set; }
        public virtual ICollection<ProdutoAuditoria> ProdutoAuditoria { get; set; }
        public virtual ICollection<ProdutosAuditoriaArmazem> ProdutosAuditoriaArmazem { get; set; }
        public virtual ICollection<ProdutosEsquivalencia> ProdutosEsquivalencia { get; set; }
        public virtual ICollection<ProdutosStockArmazem> ProdutosStockArmazem { get; set; }
        public virtual ICollection<ProdutosStockHistorico> ProdutosStockHistorico { get; set; }
        public virtual ICollection<TransferenciasArmazemOrdems> TransferenciasArmazemOrdems { get; set; }
    }
}
