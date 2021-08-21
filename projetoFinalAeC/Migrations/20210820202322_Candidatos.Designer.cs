﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projetoFinalAeC.Servicos;

namespace projetoFinalAeC.Migrations
{
    [DbContext(typeof(DbContexto))]
    [Migration("20210820202322_Candidatos")]
    partial class Candidatos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("projetoFinalAeC.Models.Candidato", b =>
                {
                    b.Property<int>("Id_Candidato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("cidade");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("email");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nascimento")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("numero");

                    b.Property<int>("ProfissaoID")
                        .HasColumnType("int")
                        .HasColumnName("profissao_id");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("telefone");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("uf");

                    b.HasKey("Id_Candidato");

                    b.HasIndex("ProfissaoID");

                    b.ToTable("candidatos");
                });

            modelBuilder.Entity("projetoFinalAeC.Models.Profissao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("descricao");

                    b.HasKey("Id");

                    b.ToTable("profissoes");
                });

            modelBuilder.Entity("projetoFinalAeC.Models.Candidato", b =>
                {
                    b.HasOne("projetoFinalAeC.Models.Profissao", "Profissao")
                        .WithMany("candidatos")
                        .HasForeignKey("ProfissaoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profissao");
                });

            modelBuilder.Entity("projetoFinalAeC.Models.Profissao", b =>
                {
                    b.Navigation("candidatos");
                });
#pragma warning restore 612, 618
        }
    }
}
