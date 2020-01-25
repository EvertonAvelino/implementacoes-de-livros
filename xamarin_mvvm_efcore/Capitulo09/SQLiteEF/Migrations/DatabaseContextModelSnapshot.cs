﻿// <auto-generated />
using CasaDoCodigo.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CasaDoCodigo.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("CasaDoCodigo.Models.Atendimento", b =>
                {
                    b.Property<long?>("AtendimentoID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ClienteID");

                    b.Property<DateTime>("DataHoraChegada");

                    b.Property<DateTime?>("DataHoraEntrega");

                    b.Property<DateTime>("DataHoraPrometida");

                    b.Property<string>("Veiculo");

                    b.HasKey("AtendimentoID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.AtendimentoFoto", b =>
                {
                    b.Property<long?>("AtendimentoFotoID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AtendimentoID");

                    b.Property<string>("CaminhoFoto");

                    b.Property<string>("Observacoes");

                    b.HasKey("AtendimentoFotoID");

                    b.HasIndex("AtendimentoID");

                    b.ToTable("AtendimentoFotos");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.AtendimentoItem", b =>
                {
                    b.Property<long?>("AtendimentoItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AtendimentoID")
                        .IsRequired();

                    b.Property<int>("Quantidade");

                    b.Property<long?>("ServicoID");

                    b.Property<double>("Valor");

                    b.HasKey("AtendimentoItemID");

                    b.HasIndex("AtendimentoID");

                    b.HasIndex("ServicoID");

                    b.ToTable("AtendimentoItens");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.Cliente", b =>
                {
                    b.Property<long?>("ClienteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EMail");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("ClienteID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CasaDoCodigo.Models.Servico", b =>
                {
                    b.Property<long?>("ServicoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<double>("Valor");

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
                    b.HasOne("CasaDoCodigo.Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoID");
                });
#pragma warning restore 612, 618
        }
    }
}
