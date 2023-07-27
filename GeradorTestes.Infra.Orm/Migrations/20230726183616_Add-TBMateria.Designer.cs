﻿// <auto-generated />
using GeradorTestes.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeradorTestes.Infra.Orm.Migrations
{
    [DbContext(typeof(GeradorTestesDbContext))]
    [Migration("20230726183616_Add-TBMateria")]
    partial class AddTBMateria
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloDisciplina.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TBDisciplina", (string)null);
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloMateria.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Serie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("TBMateria", (string)null);
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloMateria.Materia", b =>
                {
                    b.HasOne("GeradorTestes.Dominio.ModuloDisciplina.Disciplina", "Disciplina")
                        .WithMany("Materias")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBMateria_TBDisciplina");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("GeradorTestes.Dominio.ModuloDisciplina.Disciplina", b =>
                {
                    b.Navigation("Materias");
                });
#pragma warning restore 612, 618
        }
    }
}
