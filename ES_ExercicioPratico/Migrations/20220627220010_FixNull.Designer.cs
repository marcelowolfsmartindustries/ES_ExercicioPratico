// <auto-generated />
using System;
using ES_ExercicioPratico.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ES_ExercicioPratico.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220627220010_FixNull")]
    partial class FixNull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ES_ExercicioPratico.Models.Key", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRandomKey")
                        .HasColumnType("bit");

                    b.Property<int?>("Number1")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Number2")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Number3")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Number4")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Number5")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Star1")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Star2")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Keys");
                });
#pragma warning restore 612, 618
        }
    }
}
