using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VendasWebAPI.Models
{
    public partial class iSoftVendasContext : DbContext
    {
        public iSoftVendasContext()
        {
        }

        public iSoftVendasContext(DbContextOptions<iSoftVendasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anotacoes> Anotacoes { get; set; }
        public virtual DbSet<Caixa> Caixa { get; set; }
        public virtual DbSet<CaixaAnual> CaixaAnual { get; set; }
        public virtual DbSet<CaixaDescontos> CaixaDescontos { get; set; }
        public virtual DbSet<CaixaResumo> CaixaResumo { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ClientesCartaos> ClientesCartaos { get; set; }
        public virtual DbSet<ClientesPagamentosPraso> ClientesPagamentosPraso { get; set; }
        public virtual DbSet<Definicoes> Definicoes { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Divisao> Divisao { get; set; }
        public virtual DbSet<Exceptions> Exceptions { get; set; }
        public virtual DbSet<FPagamento> FPagamento { get; set; }
        public virtual DbSet<Fatura> Fatura { get; set; }
        public virtual DbSet<FaturasArmazem> FaturasArmazem { get; set; }
        public virtual DbSet<FaturasEncomendas> FaturasEncomendas { get; set; }
        public virtual DbSet<FaturasOrdemArmazem> FaturasOrdemArmazem { get; set; }
        public virtual DbSet<FaturasOrdemEncomendas> FaturasOrdemEncomendas { get; set; }
        public virtual DbSet<FaturasOrdemProformas> FaturasOrdemProformas { get; set; }
        public virtual DbSet<FaturasOrdemReservas> FaturasOrdemReservas { get; set; }
        public virtual DbSet<FaturasOrdems> FaturasOrdems { get; set; }
        public virtual DbSet<FaturasProformas> FaturasProformas { get; set; }
        public virtual DbSet<FaturasReservas> FaturasReservas { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<FornecedorCaixa> FornecedorCaixa { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<KeysGens> KeysGens { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Permissoes> Permissoes { get; set; }
        public virtual DbSet<PlanoNecessidadeOrdems> PlanoNecessidadeOrdems { get; set; }
        public virtual DbSet<PlanoNecessidades> PlanoNecessidades { get; set; }
        public virtual DbSet<PontosVenda> PontosVenda { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<ProdutoAuditoria> ProdutoAuditoria { get; set; }
        public virtual DbSet<ProdutosAuditoriaArmazem> ProdutosAuditoriaArmazem { get; set; }
        public virtual DbSet<ProdutosEsquivalencia> ProdutosEsquivalencia { get; set; }
        public virtual DbSet<ProdutosStock> ProdutosStock { get; set; }
        public virtual DbSet<ProdutosStockArmazem> ProdutosStockArmazem { get; set; }
        public virtual DbSet<ProdutosStockArmazemEstados> ProdutosStockArmazemEstados { get; set; }
        public virtual DbSet<ProdutosStockHistorico> ProdutosStockHistorico { get; set; }
        public virtual DbSet<ProdutosSugestao> ProdutosSugestao { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<SmtpConfigurations> SmtpConfigurations { get; set; }
        public virtual DbSet<SubCategoria> SubCategoria { get; set; }
        public virtual DbSet<TransferenciasArmazemOrdems> TransferenciasArmazemOrdems { get; set; }
        public virtual DbSet<TransferenciasArmazems> TransferenciasArmazems { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<UsuariosCartaos> UsuariosCartaos { get; set; }
        public virtual DbSet<UsuariosEstados> UsuariosEstados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=iSoft-Vendas;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Anotacoes>(entity =>
            {
                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.AnotacoesId).HasColumnName("AnotacoesID");

                entity.Property(e => e.AnotacoesNome).IsRequired();

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Referencia).IsRequired();

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.Anotacoes)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Anotacoes_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<Caixa>(entity =>
            {
                entity.HasIndex(e => e.DepartamentoId)
                    .HasName("IX_DepartamentoID");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.CaixaId).HasColumnName("CaixaID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.SaldoFinal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Caixa)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Caixa_dbo.Departamentos_DepartamentoID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.Caixa)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Caixa_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<CaixaAnual>(entity =>
            {
                entity.HasIndex(e => e.DepartamentoId)
                    .HasName("IX_DepartamentoID");

                entity.Property(e => e.CaixaAnualId).HasColumnName("CaixaAnualID");

                entity.Property(e => e.DataModificacao).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.CaixaAnual)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CaixaAnual_dbo.Departamentos_DepartamentoID");
            });

            modelBuilder.Entity<CaixaDescontos>(entity =>
            {
                entity.ToTable("Caixa_Descontos");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.CaixaDescontosId).HasColumnName("Caixa_DescontosID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.Property(e => e.ValorAumento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorDiminui).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.CaixaDescontos)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Caixa_Descontos_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<CaixaResumo>(entity =>
            {
                entity.HasIndex(e => e.CaixaAnualId)
                    .HasName("IX_CaixaAnualID");

                entity.Property(e => e.CaixaResumoId).HasColumnName("CaixaResumoID");

                entity.Property(e => e.CaixaAnualId).HasColumnName("CaixaAnualID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Operacao).HasMaxLength(1);

                entity.Property(e => e.SaldoFinal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaldoRemover).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CaixaAnual)
                    .WithMany(p => p.CaixaResumo)
                    .HasForeignKey(d => d.CaixaAnualId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CaixaResumo_dbo.CaixaAnual_CaixaAnualID");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasIndex(e => e.DepartamentoId)
                    .HasName("IX_DepartamentoID");

                entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");

                entity.Property(e => e.CategoriaNome)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Categoria)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Categoria_dbo.Departamentos_DepartamentoID");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.ClienteId)
                    .HasName("PK_dbo.Clientes");

                entity.HasIndex(e => new { e.ClienteNome, e.Nif, e.DepartamentoId })
                    .HasName("ClientesClienteNomeIndex")
                    .IsUnique();

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.Aniversario).HasColumnType("datetime");

                entity.Property(e => e.ClienteNome)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Contacto).HasMaxLength(100);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Desconto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Endereco).HasMaxLength(300);

                entity.Property(e => e.Nif)
                    .HasColumnName("NIF")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Clientes_dbo.Departamentos_DepartamentoID");
            });

            modelBuilder.Entity<ClientesCartaos>(entity =>
            {
                entity.HasKey(e => e.ClientesCartaoId)
                    .HasName("PK_dbo.ClientesCartaos");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("IX_ClienteID")
                    .IsUnique();

                entity.Property(e => e.ClientesCartaoId).HasColumnName("ClientesCartaoID");

                entity.Property(e => e.Bi)
                    .HasColumnName("BI")
                    .HasMaxLength(100);

                entity.Property(e => e.Bonos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.ClinetesNumero).HasMaxLength(500);

                entity.Property(e => e.Emissao).HasColumnType("datetime");

                entity.Property(e => e.Validade).HasColumnType("datetime");

                entity.HasOne(d => d.Cliente)
                    .WithOne(p => p.ClientesCartaos)
                    .HasForeignKey<ClientesCartaos>(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ClientesCartaos_dbo.Clientes_ClienteID");
            });

            modelBuilder.Entity<ClientesPagamentosPraso>(entity =>
            {
                entity.HasIndex(e => e.ClienteId)
                    .HasName("IX_ClienteID");

                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.Property(e => e.ClientesPagamentosPrasoId).HasColumnName("ClientesPagamentosPrasoID");

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.PagamentoGeral).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PagamentoParcelar).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ClientesPagamentosPraso)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ClientesPagamentosPraso_dbo.Clientes_ClienteID");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.ClientesPagamentosPraso)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ClientesPagamentosPraso_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<Definicoes>(entity =>
            {
                entity.HasIndex(e => e.DepartamentoId)
                    .HasName("IX_DepartamentoID");

                entity.Property(e => e.DefinicoesId).HasColumnName("DefinicoesID");

                entity.Property(e => e.Banco1)
                    .HasColumnName("Banco_1")
                    .HasMaxLength(400);

                entity.Property(e => e.Banco2)
                    .HasColumnName("Banco_2")
                    .HasMaxLength(400);

                entity.Property(e => e.Banco3)
                    .HasColumnName("Banco_3")
                    .HasMaxLength(400);

                entity.Property(e => e.Banco4)
                    .HasColumnName("Banco_4")
                    .HasMaxLength(400);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Email).HasMaxLength(400);

                entity.Property(e => e.Nif)
                    .HasColumnName("NIF")
                    .HasMaxLength(200);

                entity.Property(e => e.Outros).HasMaxLength(400);

                entity.Property(e => e.PhotosDesk1).HasColumnName("Photos_Desk1");

                entity.Property(e => e.PhotosDesk2).HasColumnName("Photos_Desk2");

                entity.Property(e => e.Ramo).HasMaxLength(400);

                entity.Property(e => e.Telemovel).HasMaxLength(400);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Definicoes)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Definicoes_dbo.Departamentos_DepartamentoID");
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.DepartamentoId)
                    .HasName("PK_dbo.Departamentos");

                entity.HasIndex(e => e.DivisaoId)
                    .HasName("IX_DivisaoID");

                entity.HasIndex(e => e.ProvinciaId)
                    .HasName("IX_ProvinciaID");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.DepartamentoNome)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DivisaoId).HasColumnName("DivisaoID");

                entity.Property(e => e.Localizacao)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");

                entity.HasOne(d => d.Divisao)
                    .WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.DivisaoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Departamentos_dbo.Divisao_DivisaoID");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Departamentos_dbo.Provincias_ProvinciaID");
            });

            modelBuilder.Entity<Divisao>(entity =>
            {
                entity.Property(e => e.DivisaoId).HasColumnName("DivisaoID");

                entity.Property(e => e.DivisaoNome).IsRequired();
            });

            modelBuilder.Entity<Exceptions>(entity =>
            {
                entity.HasKey(e => e.ExceptionId)
                    .HasName("PK_dbo.Exceptions");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.ExceptionId).HasColumnName("ExceptionID");

                entity.Property(e => e.DataHoras)
                    .HasColumnName("Data_Horas")
                    .HasColumnType("datetime");

                entity.Property(e => e.Erro).IsRequired();

                entity.Property(e => e.Formulario)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Metodo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.Exceptions)
                    .HasForeignKey(d => d.UsuariosId)
                    .HasConstraintName("FK_dbo.Exceptions_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<FPagamento>(entity =>
            {
                entity.ToTable("F_Pagamento");

                entity.Property(e => e.FpagamentoId).HasColumnName("FpagamentoID");

                entity.Property(e => e.Fpagamento1).HasColumnName("Fpagamento");
            });

            modelBuilder.Entity<Fatura>(entity =>
            {
                entity.HasKey(e => e.FaturasNumero)
                    .HasName("PK_dbo.Fatura");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("IX_ClienteID");

                entity.HasIndex(e => e.FpagamentoId)
                    .HasName("IX_FpagamentoID");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.FaturasNumero)
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.FaturasId)
                    .HasColumnName("FaturasID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FpagamentoId).HasColumnName("FpagamentoID");

                entity.Property(e => e.GrandeTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrandeTotalBanco).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrandeTotalFisico).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Parc2DescPerc)
                    .HasColumnName("Parc2Desc_Perc")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Porc1Desc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.Property(e => e.ValorPago)
                    .HasColumnName("Valor_Pago")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorPagoTroco)
                    .HasColumnName("ValorPago_Troco")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Fatura)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Fatura_dbo.Clientes_ClienteID");

                entity.HasOne(d => d.Fpagamento)
                    .WithMany(p => p.Fatura)
                    .HasForeignKey(d => d.FpagamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Fatura_dbo.F_Pagamento_FpagamentoID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.Fatura)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Fatura_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<FaturasArmazem>(entity =>
            {
                entity.HasKey(e => e.FaturasNumero)
                    .HasName("PK_dbo.FaturasArmazem");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("IX_ClienteID");

                entity.HasIndex(e => e.FpagamentoId)
                    .HasName("IX_FpagamentoID");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.FaturasNumero)
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.FaturasArmazemId)
                    .HasColumnName("Faturas_ArmazemID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FpagamentoId).HasColumnName("FpagamentoID");

                entity.Property(e => e.GrandeTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrandeTotalBanco).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrandeTotalFisico).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Parc2DescPerc)
                    .HasColumnName("Parc2Desc_Perc")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Porc1Desc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.Property(e => e.ValorPago)
                    .HasColumnName("Valor_Pago")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorPagoTroco)
                    .HasColumnName("ValorPago_Troco")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.FaturasArmazem)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FaturasArmazem_dbo.Clientes_ClienteID");

                entity.HasOne(d => d.Fpagamento)
                    .WithMany(p => p.FaturasArmazem)
                    .HasForeignKey(d => d.FpagamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FaturasArmazem_dbo.F_Pagamento_FpagamentoID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.FaturasArmazem)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FaturasArmazem_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<FaturasEncomendas>(entity =>
            {
                entity.HasKey(e => e.FaturasNumero)
                    .HasName("PK_dbo.FaturasEncomendas");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("IX_ClienteID");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.FaturasNumero)
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.DataEntrega).HasColumnType("date");

                entity.Property(e => e.FaturasEncomendasId)
                    .HasColumnName("FaturasEncomendasID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.FaturasEncomendas)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK_dbo.FaturasEncomendas_dbo.Clientes_ClienteID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.FaturasEncomendas)
                    .HasForeignKey(d => d.UsuariosId)
                    .HasConstraintName("FK_dbo.FaturasEncomendas_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<FaturasOrdemArmazem>(entity =>
            {
                entity.ToTable("FaturasOrdem_Armazem");

                entity.HasIndex(e => e.FaturasNumero)
                    .HasName("IX_FaturasNumero");

                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.Property(e => e.FaturasOrdemArmazemId).HasColumnName("FaturasOrdemArmazemID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.FaturasNumero).HasMaxLength(40);

                entity.Property(e => e.PrecoUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.FaturasNumeroNavigation)
                    .WithMany(p => p.FaturasOrdemArmazem)
                    .HasForeignKey(d => d.FaturasNumero)
                    .HasConstraintName("FK_dbo.FaturasOrdem_Armazem_dbo.FaturasArmazem_FaturasNumero");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.FaturasOrdemArmazem)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FaturasOrdem_Armazem_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<FaturasOrdemEncomendas>(entity =>
            {
                entity.HasIndex(e => e.FaturasNumero)
                    .HasName("IX_FaturasNumero");

                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.Property(e => e.FaturasOrdemEncomendasId).HasColumnName("FaturasOrdemEncomendasID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.FaturasNumero).HasMaxLength(40);

                entity.Property(e => e.PrecoUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.FaturasNumeroNavigation)
                    .WithMany(p => p.FaturasOrdemEncomendas)
                    .HasForeignKey(d => d.FaturasNumero)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.FaturasOrdemEncomendas_dbo.FaturasEncomendas_FaturasNumero");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.FaturasOrdemEncomendas)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FaturasOrdemEncomendas_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<FaturasOrdemProformas>(entity =>
            {
                entity.HasKey(e => e.FaturasOrdemId)
                    .HasName("PK_dbo.FaturasOrdemProformas");

                entity.HasIndex(e => e.FaturasNumero)
                    .HasName("IX_FaturasNumero");

                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.Property(e => e.FaturasOrdemId).HasColumnName("FaturasOrdemID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.FaturasNumero).HasMaxLength(40);

                entity.Property(e => e.PrecoUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.FaturasNumeroNavigation)
                    .WithMany(p => p.FaturasOrdemProformas)
                    .HasForeignKey(d => d.FaturasNumero)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.FaturasOrdemProformas_dbo.FaturasProformas_FaturasNumero");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.FaturasOrdemProformas)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FaturasOrdemProformas_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<FaturasOrdemReservas>(entity =>
            {
                entity.HasKey(e => e.FaturasOrdemId)
                    .HasName("PK_dbo.FaturasOrdemReservas");

                entity.HasIndex(e => e.FaturasNumero)
                    .HasName("IX_FaturasNumero");

                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.Property(e => e.FaturasOrdemId).HasColumnName("FaturasOrdemID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.FaturasNumero).HasMaxLength(40);

                entity.Property(e => e.PrecoUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.FaturasNumeroNavigation)
                    .WithMany(p => p.FaturasOrdemReservas)
                    .HasForeignKey(d => d.FaturasNumero)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.FaturasOrdemReservas_dbo.FaturasReservas_FaturasNumero");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.FaturasOrdemReservas)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FaturasOrdemReservas_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<FaturasOrdems>(entity =>
            {
                entity.HasKey(e => e.FaturasOrdemId)
                    .HasName("PK_dbo.FaturasOrdems");

                entity.HasIndex(e => e.FaturasNumero)
                    .HasName("IX_FaturasNumero");

                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.Property(e => e.FaturasOrdemId).HasColumnName("FaturasOrdemID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.FaturasNumero).HasMaxLength(40);

                entity.Property(e => e.PrecoUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.FaturasNumeroNavigation)
                    .WithMany(p => p.FaturasOrdems)
                    .HasForeignKey(d => d.FaturasNumero)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.FaturasOrdems_dbo.Fatura_FaturasNumero");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.FaturasOrdems)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FaturasOrdems_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<FaturasProformas>(entity =>
            {
                entity.HasKey(e => e.FaturasNumero)
                    .HasName("PK_dbo.FaturasProformas");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("IX_ClienteID");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.FaturasNumero)
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.FaturasId)
                    .HasColumnName("FaturasID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.FaturasProformas)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK_dbo.FaturasProformas_dbo.Clientes_ClienteID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.FaturasProformas)
                    .HasForeignKey(d => d.UsuariosId)
                    .HasConstraintName("FK_dbo.FaturasProformas_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<FaturasReservas>(entity =>
            {
                entity.HasKey(e => e.FaturasNumero)
                    .HasName("PK_dbo.FaturasReservas");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("IX_ClienteID");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.FaturasNumero)
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.DataEntrega).HasColumnType("date");

                entity.Property(e => e.FaturasId)
                    .HasColumnName("FaturasID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nparcelas).HasColumnName("NParcelas");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UltimoValor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.Property(e => e.Vacrescido)
                    .HasColumnName("VAcrescido")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vrestante)
                    .HasColumnName("VRestante")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.FaturasReservas)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FaturasReservas_dbo.Clientes_ClienteID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.FaturasReservas)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FaturasReservas_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasIndex(e => e.DepartamentoId)
                    .HasName("IX_DepartamentoID");

                entity.HasIndex(e => e.ProvinciaId)
                    .HasName("IX_ProvinciaID");

                entity.HasIndex(e => new { e.FornecedorNome, e.Nif })
                    .HasName("FornecedorFornecedorNomeIndex")
                    .IsUnique();

                entity.Property(e => e.FornecedorId).HasColumnName("FornecedorID");

                entity.Property(e => e.Contacto).HasMaxLength(100);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Endereco).HasMaxLength(300);

                entity.Property(e => e.FornecedorNome)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Nif)
                    .HasColumnName("NIF")
                    .HasMaxLength(100);

                entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");

                entity.Property(e => e.RuaLocalidade)
                    .HasColumnName("Rua_Localidade")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Fornecedor)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Fornecedor_dbo.Departamentos_DepartamentoID");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Fornecedor)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Fornecedor_dbo.Provincias_ProvinciaID");
            });

            modelBuilder.Entity<FornecedorCaixa>(entity =>
            {
                entity.HasIndex(e => e.FornecedorId)
                    .HasName("IX_FornecedorID");

                entity.Property(e => e.FornecedorCaixaId).HasColumnName("FornecedorCaixaID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.FornecedorId).HasColumnName("FornecedorID");

                entity.Property(e => e.Vcreditar)
                    .HasColumnName("VCreditar")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vdebitar)
                    .HasColumnName("VDebitar")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Fornecedor)
                    .WithMany(p => p.FornecedorCaixa)
                    .HasForeignKey(d => d.FornecedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FornecedorCaixa_dbo.Fornecedor_FornecedorID");
            });

            modelBuilder.Entity<Grupos>(entity =>
            {
                entity.HasKey(e => e.GrupoId)
                    .HasName("PK_dbo.Grupos");

                entity.HasIndex(e => new { e.GrupoNome, e.DepartamentoId })
                    .HasName("GruposGrupoNomeIndex")
                    .IsUnique();

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.GrupoNome)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Grupos)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Grupos_dbo.Departamentos_DepartamentoID");
            });

            modelBuilder.Entity<KeysGens>(entity =>
            {
                entity.HasKey(e => e.KeysGenId)
                    .HasName("PK_dbo.KeysGens");

                entity.Property(e => e.KeysGenId).HasColumnName("KeysGenID");

                entity.Property(e => e.DataActual).HasColumnType("datetime");

                entity.Property(e => e.DataFinal).HasColumnType("datetime");
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.LogsId).HasColumnName("LogsID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Operacao).IsRequired();

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Logs_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.HasKey(e => e.MunicioId)
                    .HasName("PK_dbo.Municipios");

                entity.HasIndex(e => e.ProvinciaId)
                    .HasName("IX_ProvinciaID");

                entity.Property(e => e.MunicioId).HasColumnName("MunicioID");

                entity.Property(e => e.Densidade).HasMaxLength(100);

                entity.Property(e => e.Localizacao).HasMaxLength(100);

                entity.Property(e => e.MunicipioNome)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Municipios_dbo.Provincias_ProvinciaID");
            });

            modelBuilder.Entity<Pedidos>(entity =>
            {
                entity.HasIndex(e => e.FaturasNumero)
                    .HasName("IX_FaturasNumero");

                entity.Property(e => e.PedidosId).HasColumnName("PedidosID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.FaturasNumero).HasMaxLength(40);

                entity.HasOne(d => d.FaturasNumeroNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.FaturasNumero)
                    .HasConstraintName("FK_dbo.Pedidos_dbo.Fatura_FaturasNumero");
            });

            modelBuilder.Entity<Permissoes>(entity =>
            {
                entity.HasIndex(e => e.GrupoId)
                    .HasName("IX_GrupoID");

                entity.Property(e => e.PermissoesId).HasColumnName("PermissoesID");

                entity.Property(e => e.BackupActivarDesativar).HasColumnName("Backup_Activar_Desativar");

                entity.Property(e => e.BackupAutomatico).HasColumnName("Backup_Automatico");

                entity.Property(e => e.BackupManual).HasColumnName("Backup_Manual");

                entity.Property(e => e.BtnInventariosFechosArmazem).HasColumnName("btnInventariosFechosArmazem");

                entity.Property(e => e.BtnRelatorioGeral).HasColumnName("btnRelatorioGeral");

                entity.Property(e => e.CadBarra).HasColumnName("Cad_Barra_");

                entity.Property(e => e.CaixaDesconto).HasColumnName("Caixa_Desconto");

                entity.Property(e => e.DefinicoesConsultas).HasColumnName("Definicoes_Consultas");

                entity.Property(e => e.DefinicoesDepartamentos).HasColumnName("Definicoes_Departamentos");

                entity.Property(e => e.Departamento).HasColumnName("departamento");

                entity.Property(e => e.DivisaoEmpresa).HasColumnName("Divisao_Empresa");

                entity.Property(e => e.ErrosLogs).HasColumnName("Erros_Logs");

                entity.Property(e => e.ErrosLogsReport).HasColumnName("Erros_LogsReport");

                entity.Property(e => e.FpagamentosAdicionar).HasColumnName("FPagamentosAdicionar");

                entity.Property(e => e.FpagamentosConsultas).HasColumnName("FPagamentosConsultas");

                entity.Property(e => e.FpagamentosConsultasReport).HasColumnName("FPagamentosConsultasReport");

                entity.Property(e => e.GraficosActivarDesativar).HasColumnName("GraficosActivar_Desativar");

                entity.Property(e => e.GraficosLogoMarca).HasColumnName("Graficos_LogoMarca");

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.Grupos).HasColumnName("grupos");

                entity.Property(e => e.GruposAdicionar).HasColumnName("Grupos_Adicionar");

                entity.Property(e => e.GruposConsultar).HasColumnName("Grupos_Consultar");

                entity.Property(e => e.UsuariosAdicionar).HasColumnName("Usuarios_Adicionar");

                entity.Property(e => e.UsuariosConsultar).HasColumnName("Usuarios_Consultar");

                entity.Property(e => e.UsuariosOnline).HasColumnName("Usuarios_ONLINE");

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.Permissoes)
                    .HasForeignKey(d => d.GrupoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Permissoes_dbo.Grupos_GrupoID");
            });

            modelBuilder.Entity<PlanoNecessidadeOrdems>(entity =>
            {
                entity.HasKey(e => e.PlanoNecessidadeOrdemOrdemId)
                    .HasName("PK_dbo.PlanoNecessidadeOrdems");

                entity.HasIndex(e => e.PontosVendaId)
                    .HasName("IX_PontosVendaID");

                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.HasIndex(e => e.Referencia)
                    .HasName("IX_Referencia");

                entity.Property(e => e.PlanoNecessidadeOrdemOrdemId).HasColumnName("PlanoNecessidadeOrdemOrdemID");

                entity.Property(e => e.PontosVendaId).HasColumnName("PontosVendaID");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.Property(e => e.Referencia).HasMaxLength(40);

                entity.HasOne(d => d.PontosVenda)
                    .WithMany(p => p.PlanoNecessidadeOrdems)
                    .HasForeignKey(d => d.PontosVendaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PlanoNecessidadeOrdems_dbo.PontosVenda_PontosVendaID");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.PlanoNecessidadeOrdems)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PlanoNecessidadeOrdems_dbo.Produto_ProdutoID");

                entity.HasOne(d => d.ReferenciaNavigation)
                    .WithMany(p => p.PlanoNecessidadeOrdems)
                    .HasForeignKey(d => d.Referencia)
                    .HasConstraintName("FK_dbo.PlanoNecessidadeOrdems_dbo.PlanoNecessidades_Referencia");
            });

            modelBuilder.Entity<PlanoNecessidades>(entity =>
            {
                entity.HasKey(e => e.Referencia)
                    .HasName("PK_dbo.PlanoNecessidades");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.PlanoNecessidadeId)
                    .HasColumnName("PlanoNecessidadeID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PontosVenda>(entity =>
            {
                entity.Property(e => e.PontosVendaId).HasColumnName("PontosVendaID");

                entity.Property(e => e.PontosVendaNome)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasIndex(e => e.FornecedorId)
                    .HasName("IX_FornecedorID");

                entity.HasIndex(e => e.SubCategoriaId)
                    .HasName("IX_SubCategoriaID");

                entity.HasIndex(e => new { e.ProdutoNome, e.DepartamentoId })
                    .HasName("Produtos_ProdutoNome_Index")
                    .IsUnique();

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.Property(e => e.CodigoBarra)
                    .HasColumnName("Codigo_Barra")
                    .HasMaxLength(300);

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Fabricante).HasMaxLength(150);

                entity.Property(e => e.FornecedorId).HasColumnName("FornecedorID");

                entity.Property(e => e.Marca).HasMaxLength(150);

                entity.Property(e => e.PrecoCompra)
                    .HasColumnName("Preco_Compra")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoNome)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ProdutoValidade1).HasColumnType("datetime");

                entity.Property(e => e.ProdutoValidade2).HasColumnType("datetime");

                entity.Property(e => e.SubCategoriaId).HasColumnName("SubCategoriaID");

                entity.Property(e => e.UnidadeMedida).HasMaxLength(50);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Produto_dbo.Departamentos_DepartamentoID");

                entity.HasOne(d => d.Fornecedor)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.FornecedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Produto_dbo.Fornecedor_FornecedorID");

                entity.HasOne(d => d.SubCategoria)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.SubCategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Produto_dbo.SubCategoria_SubCategoriaID");
            });

            modelBuilder.Entity<ProdutoAuditoria>(entity =>
            {
                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.Property(e => e.ProdutoAuditoriaId).HasColumnName("ProdutoAuditoriaID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.ProdutoAuditoria)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProdutoAuditoria_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<ProdutosAuditoriaArmazem>(entity =>
            {
                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.Property(e => e.ProdutosAuditoriaArmazemId).HasColumnName("ProdutosAuditoriaArmazemID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.ProdutosAuditoriaArmazem)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProdutosAuditoriaArmazem_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<ProdutosEsquivalencia>(entity =>
            {
                entity.HasIndex(e => e.ProdutoId1)
                    .HasName("IX_ProdutoID");

                entity.Property(e => e.ProdutosEsquivalenciaId).HasColumnName("ProdutosEsquivalenciaID");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID_");

                entity.Property(e => e.ProdutoId1).HasColumnName("ProdutoID");

                entity.Property(e => e.ProdutoNomeRep).HasColumnName("ProdutoNome_Rep");

                entity.HasOne(d => d.ProdutoId1Navigation)
                    .WithMany(p => p.ProdutosEsquivalencia)
                    .HasForeignKey(d => d.ProdutoId1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProdutosEsquivalencia_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<ProdutosStock>(entity =>
            {
                entity.HasIndex(e => e.ProdutoId)
                    .HasName("Produtos_ProdutoID_Index")
                    .IsUnique();

                entity.Property(e => e.ProdutosStockId).HasColumnName("ProdutosStockID");

                entity.Property(e => e.Custos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.ImpostoConsumo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecoTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecoTotal2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecoVenda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecoVenda2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.HasOne(d => d.Produto)
                    .WithOne(p => p.ProdutosStock)
                    .HasForeignKey<ProdutosStock>(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProdutosStock_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<ProdutosStockArmazem>(entity =>
            {
                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.HasIndex(e => e.ProdutosStockArmazemEstadosId)
                    .HasName("IX_ProdutosStockArmazemEstadosID");

                entity.Property(e => e.ProdutosStockArmazemId).HasColumnName("ProdutosStockArmazemID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.PrecoTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecoVenda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.Property(e => e.ProdutosStockArmazemEstadosId).HasColumnName("ProdutosStockArmazemEstadosID");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.ProdutosStockArmazem)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProdutosStockArmazem_dbo.Produto_ProdutoID");

                entity.HasOne(d => d.ProdutosStockArmazemEstados)
                    .WithMany(p => p.ProdutosStockArmazem)
                    .HasForeignKey(d => d.ProdutosStockArmazemEstadosId)
                    .HasConstraintName("FK_dbo.ProdutosStockArmazem_dbo.ProdutosStockArmazemEstados_ProdutosStockArmazemEstadosID");
            });

            modelBuilder.Entity<ProdutosStockArmazemEstados>(entity =>
            {
                entity.Property(e => e.ProdutosStockArmazemEstadosId).HasColumnName("ProdutosStockArmazemEstadosID");

                entity.Property(e => e.Estado).IsRequired();
            });

            modelBuilder.Entity<ProdutosStockHistorico>(entity =>
            {
                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.Property(e => e.ProdutosStockHistoricoId).HasColumnName("ProdutosStockHistoricoID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.PrecoTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecoVenda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.ProdutosStockHistorico)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProdutosStockHistorico_dbo.Produto_ProdutoID");
            });

            modelBuilder.Entity<ProdutosSugestao>(entity =>
            {
                entity.HasIndex(e => e.DepartamentoId)
                    .HasName("IX_DepartamentoID");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.ProdutosSugestaoId).HasColumnName("ProdutosSugestaoID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.Produtos).HasMaxLength(100);

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.ProdutosSugestao)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProdutosSugestao_dbo.Departamentos_DepartamentoID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.ProdutosSugestao)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProdutosSugestao_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.HasKey(e => e.ProvinciaId)
                    .HasName("PK_dbo.Provincias");

                entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");

                entity.Property(e => e.Clima).HasMaxLength(100);

                entity.Property(e => e.Densidade).HasMaxLength(100);

                entity.Property(e => e.Localizacao).HasMaxLength(100);

                entity.Property(e => e.ProvinciaNome)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Riquesas).HasMaxLength(500);
            });

            modelBuilder.Entity<SmtpConfigurations>(entity =>
            {
                entity.HasKey(e => e.SmtpConfigurationId)
                    .HasName("PK_dbo.SmtpConfigurations");

                entity.Property(e => e.SmtpConfigurationId).HasColumnName("SmtpConfigurationID");
            });

            modelBuilder.Entity<SubCategoria>(entity =>
            {
                entity.HasIndex(e => e.CategoriaId)
                    .HasName("IX_CategoriaID");

                entity.Property(e => e.SubCategoriaId).HasColumnName("SubCategoriaID");

                entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");

                entity.Property(e => e.SubCategoriaNome)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.SubCategoria)
                    .HasForeignKey(d => d.CategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SubCategoria_dbo.Categoria_CategoriaID");
            });

            modelBuilder.Entity<TransferenciasArmazemOrdems>(entity =>
            {
                entity.HasKey(e => e.TransferenciasArmazemOrdemId)
                    .HasName("PK_dbo.TransferenciasArmazemOrdems");

                entity.HasIndex(e => e.PontosVendaId)
                    .HasName("IX_PontosVendaID");

                entity.HasIndex(e => e.ProdutoId)
                    .HasName("IX_ProdutoID");

                entity.HasIndex(e => e.Referencia)
                    .HasName("IX_Referencia");

                entity.Property(e => e.TransferenciasArmazemOrdemId).HasColumnName("TransferenciasArmazemOrdemID");

                entity.Property(e => e.PontosVendaId).HasColumnName("PontosVendaID");

                entity.Property(e => e.PrecoInicial)
                    .HasColumnName("Preco_Inicial")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecoTotal)
                    .HasColumnName("Preco_Total")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");

                entity.Property(e => e.Referencia).HasMaxLength(40);

                entity.HasOne(d => d.PontosVenda)
                    .WithMany(p => p.TransferenciasArmazemOrdems)
                    .HasForeignKey(d => d.PontosVendaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TransferenciasArmazemOrdems_dbo.PontosVenda_PontosVendaID");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.TransferenciasArmazemOrdems)
                    .HasForeignKey(d => d.ProdutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TransferenciasArmazemOrdems_dbo.Produto_ProdutoID");

                entity.HasOne(d => d.ReferenciaNavigation)
                    .WithMany(p => p.TransferenciasArmazemOrdems)
                    .HasForeignKey(d => d.Referencia)
                    .HasConstraintName("FK_dbo.TransferenciasArmazemOrdems_dbo.TransferenciasArmazems_Referencia");
            });

            modelBuilder.Entity<TransferenciasArmazems>(entity =>
            {
                entity.HasKey(e => e.Referencia)
                    .HasName("PK_dbo.TransferenciasArmazems");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.TransferenciasArmazemId)
                    .HasColumnName("TransferenciasArmazemID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Vtotal)
                    .HasColumnName("VTotal")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("Usuarios_Email_Index")
                    .IsUnique();

                entity.HasIndex(e => new { e.Pin, e.GrupoId })
                    .HasName("Usuarios_PIN_Index")
                    .IsUnique();

                entity.HasIndex(e => new { e.Login, e.Senha, e.GrupoId })
                    .HasName("Usuarios_Login_Index")
                    .IsUnique();

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.Property(e => e.Apelido)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DataNascimento)
                    .HasColumnName("Data_Nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(400);

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Perfil).HasColumnName("perfil");

                entity.Property(e => e.Pin)
                    .HasColumnName("PIN")
                    .HasMaxLength(400);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.UsuarioNomeCompleto)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.GrupoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Usuarios_dbo.Grupos_GrupoID");
            });

            modelBuilder.Entity<UsuariosCartaos>(entity =>
            {
                entity.HasKey(e => e.UsuariosCartaoId)
                    .HasName("PK_dbo.UsuariosCartaos");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.UsuariosCartaoId).HasColumnName("UsuariosCartaoID");

                entity.Property(e => e.Emissao).HasColumnType("datetime");

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.Property(e => e.UsuariosNumero).HasMaxLength(500);

                entity.Property(e => e.Validade).HasColumnType("datetime");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.UsuariosCartaos)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UsuariosCartaos_dbo.Usuarios_UsuariosID");
            });

            modelBuilder.Entity<UsuariosEstados>(entity =>
            {
                entity.ToTable("Usuarios_Estados");

                entity.HasIndex(e => e.UsuariosId)
                    .HasName("IX_UsuariosID");

                entity.Property(e => e.UsuariosEstadosId).HasColumnName("Usuarios_EstadosID");

                entity.Property(e => e.DataHoras)
                    .HasColumnName("Data_Horas")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuariosId).HasColumnName("UsuariosID");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.UsuariosEstados)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Usuarios_Estados_dbo.Usuarios_UsuariosID");
            });
        }
    }
}
