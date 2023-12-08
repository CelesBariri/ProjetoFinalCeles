﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinalCeles.Models;

#nullable disable

namespace ProjetoFinalCeles.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231207131337_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoFinalCeles.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CidadeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CidadeNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CidadeNome");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("ClienteCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteCpf");

                    b.Property<string>("ClienteEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteEndereco");

                    b.Property<string>("ClienteNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNome");

                    b.Property<string>("ClienteNumero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNumero");

                    b.Property<string>("ClienteSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteSexo");

                    b.Property<string>("ClienteTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteTelefone");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ColaboradorId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("ColaboradorCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorCpf");

                    b.Property<string>("ColaboradorNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorNome");

                    b.Property<string>("ColaboradorSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorSexo");

                    b.Property<string>("ColaboradorTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorTelefone");

                    b.Property<int>("TipoColaboradorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("TipoColaboradorId");

                    b.ToTable("Colaborador");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EstadoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EstadoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EstadoNome");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.LocalRealizacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LocalRealizacaoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("LocalRealizacaoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LocalRealizacaoNome");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("LocalRealizacao");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.Procedimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProcedimentoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ProcedimentoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProcedimentoNome");

                    b.Property<string>("ProcedimentoObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProcedimentoObservacao");

                    b.Property<int>("TipoProcedimentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoProcedimentoId");

                    b.ToTable("Procedimento");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.ProcedimentoRealizado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProcedimentoRealizadoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataRealizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataRealizacao");

                    b.Property<int?>("LocalRealizacaoId")
                        .HasColumnType("int");

                    b.Property<string>("ObservacaoRealizacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacaoRealizacao");

                    b.Property<int?>("ProcedimentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("LocalRealizacaoId");

                    b.HasIndex("ProcedimentoId");

                    b.ToTable("ProcedimentoReaizado");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.TipoColaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoColaboradorId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TipoColaboradorNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoColaboradorNome");

                    b.HasKey("Id");

                    b.ToTable("TipoColaborador");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.TipoProcedimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoProcedimentoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TipoProcedimentoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoProcedimentoNome");

                    b.HasKey("Id");

                    b.ToTable("TipoProcedimento");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.Cidade", b =>
                {
                    b.HasOne("ProjetoFinalCeles.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.Cliente", b =>
                {
                    b.HasOne("ProjetoFinalCeles.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.Colaborador", b =>
                {
                    b.HasOne("ProjetoFinalCeles.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoFinalCeles.Models.TipoColaborador", "TipoColaborador")
                        .WithMany()
                        .HasForeignKey("TipoColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("TipoColaborador");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.LocalRealizacao", b =>
                {
                    b.HasOne("ProjetoFinalCeles.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.Procedimento", b =>
                {
                    b.HasOne("ProjetoFinalCeles.Models.TipoProcedimento", "TipoProcedimento")
                        .WithMany()
                        .HasForeignKey("TipoProcedimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoProcedimento");
                });

            modelBuilder.Entity("ProjetoFinalCeles.Models.ProcedimentoRealizado", b =>
                {
                    b.HasOne("ProjetoFinalCeles.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("ProjetoFinalCeles.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId");

                    b.HasOne("ProjetoFinalCeles.Models.LocalRealizacao", "LocalRealizacao")
                        .WithMany()
                        .HasForeignKey("LocalRealizacaoId");

                    b.HasOne("ProjetoFinalCeles.Models.Procedimento", "Procedimento")
                        .WithMany()
                        .HasForeignKey("ProcedimentoId");

                    b.Navigation("Cliente");

                    b.Navigation("Colaborador");

                    b.Navigation("LocalRealizacao");

                    b.Navigation("Procedimento");
                });
#pragma warning restore 612, 618
        }
    }
}
