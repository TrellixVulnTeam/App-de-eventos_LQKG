﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProEventos.InfraStructure.Data;

namespace ProEventos.InfraStructure.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211022005127_CampoNameinLote")]
    partial class CampoNameinLote
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProEventos.Domain.Entities.EventoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataEvento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdPessoas")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.LoteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.ToTable("Lotes");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.PalestranteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinuCurriculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Palestrantes");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.PalestranteEventoEntity", b =>
                {
                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<int>("PalestranteId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventoId", "PalestranteId");

                    b.HasIndex("PalestranteId");

                    b.ToTable("PalestranteEventos");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.RedeSocialEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventoId")
                        .HasColumnType("int");

                    b.Property<int?>("PalestranteId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("PalestranteId");

                    b.ToTable("RedesSociais");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.LoteEntity", b =>
                {
                    b.HasOne("ProEventos.Domain.Entities.EventoEntity", "Evento")
                        .WithMany("Lotes")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.PalestranteEventoEntity", b =>
                {
                    b.HasOne("ProEventos.Domain.Entities.EventoEntity", "Evento")
                        .WithMany("PalestranteEventos")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProEventos.Domain.Entities.PalestranteEntity", "Palestrante")
                        .WithMany("PalestranteEventos")
                        .HasForeignKey("PalestranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");

                    b.Navigation("Palestrante");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.RedeSocialEntity", b =>
                {
                    b.HasOne("ProEventos.Domain.Entities.EventoEntity", "Evento")
                        .WithMany("RedesSociais")
                        .HasForeignKey("EventoId");

                    b.HasOne("ProEventos.Domain.Entities.PalestranteEntity", "Palestrante")
                        .WithMany("RedesSociais")
                        .HasForeignKey("PalestranteId");

                    b.Navigation("Evento");

                    b.Navigation("Palestrante");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.EventoEntity", b =>
                {
                    b.Navigation("Lotes");

                    b.Navigation("PalestranteEventos");

                    b.Navigation("RedesSociais");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.PalestranteEntity", b =>
                {
                    b.Navigation("PalestranteEventos");

                    b.Navigation("RedesSociais");
                });
#pragma warning restore 612, 618
        }
    }
}