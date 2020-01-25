﻿// <auto-generated />
using CasaDoCodigo.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Capitulo06Migrations.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180503194104_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

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
#pragma warning restore 612, 618
        }
    }
}
