﻿// <auto-generated />
using System;
using CasaDoCodigo.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CasaDoCodigo.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200806151443_Pecas")]
    partial class Pecas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("CasaDoCodigo.Models.Atendimento", b =>
                {
                    b.Property<long?>("AtendimentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ClienteID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataHoraChegada")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataHoraEntrega")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataHoraPrometida")
                        .HasColumnType("TEXT");

                    b.Property<string>("Veiculo")
                        .HasColumnType("TEXT");

                    b.HasKey("AtendimentoID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.AtendimentoFoto", b =>
                {
                    b.Property<long?>("AtendimentoFotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("AtendimentoID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CaminhoFoto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacoes")
                        .HasColumnType("TEXT");

                    b.HasKey("AtendimentoFotoID");

                    b.HasIndex("AtendimentoID");

                    b.ToTable("AtendimentoFotos");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.AtendimentoItem", b =>
                {
                    b.Property<long?>("AtendimentoItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("AtendimentoID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ServicoID")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("AtendimentoItemID");

                    b.HasIndex("AtendimentoID");

                    b.HasIndex("ServicoID");

                    b.ToTable("AtendimentoItens");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.Cliente", b =>
                {
                    b.Property<long?>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.Peca", b =>
                {
                    b.Property<Guid>("PecaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CaminhoImagem")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Sincronizado")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("PecaID");

                    b.ToTable("Pecas");
                });

            modelBuilder.Entity("OficinaModels.Cadastros.Servico", b =>
                {
                    b.Property<long?>("ServicoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("ServicoID");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.Atendimento", b =>
                {
                    b.HasOne("CasaDoCodigo.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.AtendimentoFoto", b =>
                {
                    b.HasOne("CasaDoCodigo.Models.Atendimento", "Atendimento")
                        .WithMany("Fotos")
                        .HasForeignKey("AtendimentoID");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.AtendimentoItem", b =>
                {
                    b.HasOne("CasaDoCodigo.Models.Atendimento", "Atendimento")
                        .WithMany("Servicos")
                        .HasForeignKey("AtendimentoID");

                    b.HasOne("OficinaModels.Cadastros.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoID");
                });
#pragma warning restore 612, 618
        }
    }
}
