using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Anotacoes = new HashSet<Anotacoes>();
            Caixa = new HashSet<Caixa>();
            CaixaDescontos = new HashSet<CaixaDescontos>();
            Exceptions = new HashSet<Exceptions>();
            Fatura = new HashSet<Fatura>();
            FaturasArmazem = new HashSet<FaturasArmazem>();
            FaturasEncomendas = new HashSet<FaturasEncomendas>();
            FaturasProformas = new HashSet<FaturasProformas>();
            FaturasReservas = new HashSet<FaturasReservas>();
            Logs = new HashSet<Logs>();
            ProdutosSugestao = new HashSet<ProdutosSugestao>();
            UsuariosCartaos = new HashSet<UsuariosCartaos>();
            UsuariosEstados = new HashSet<UsuariosEstados>();
        }

        public int UsuariosId { get; set; }
        public string UsuarioNomeCompleto { get; set; }
        public string Apelido { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Pin { get; set; }
        public bool Estado { get; set; }
        public byte[] Perfil { get; set; }
        public int GrupoId { get; set; }

        public virtual Grupos Grupo { get; set; }
        public virtual ICollection<Anotacoes> Anotacoes { get; set; }
        public virtual ICollection<Caixa> Caixa { get; set; }
        public virtual ICollection<CaixaDescontos> CaixaDescontos { get; set; }
        public virtual ICollection<Exceptions> Exceptions { get; set; }
        public virtual ICollection<Fatura> Fatura { get; set; }
        public virtual ICollection<FaturasArmazem> FaturasArmazem { get; set; }
        public virtual ICollection<FaturasEncomendas> FaturasEncomendas { get; set; }
        public virtual ICollection<FaturasProformas> FaturasProformas { get; set; }
        public virtual ICollection<FaturasReservas> FaturasReservas { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<ProdutosSugestao> ProdutosSugestao { get; set; }
        public virtual ICollection<UsuariosCartaos> UsuariosCartaos { get; set; }
        public virtual ICollection<UsuariosEstados> UsuariosEstados { get; set; }
    }
}
