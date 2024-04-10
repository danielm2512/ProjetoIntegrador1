﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjetoIntegrador.Data;

#nullable disable

namespace ProjetoIntegrador.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AddressEntityProfessorEntity", b =>
                {
                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProfessoresId")
                        .HasColumnType("bigint");

                    b.HasKey("AddressId", "ProfessoresId");

                    b.HasIndex("ProfessoresId");

                    b.ToTable("AddressEntityProfessorEntity");
                });

            modelBuilder.Entity("CrecheEntityUserEntity", b =>
                {
                    b.Property<long>("AdministradoresId")
                        .HasColumnType("bigint");

                    b.Property<long>("CrechesId")
                        .HasColumnType("bigint");

                    b.HasKey("AdministradoresId", "CrechesId");

                    b.HasIndex("CrechesId");

                    b.ToTable("CrecheEntityUserEntity");
                });

            modelBuilder.Entity("EventEntityUserEntity", b =>
                {
                    b.Property<long>("EventsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UsersId")
                        .HasColumnType("bigint");

                    b.HasKey("EventsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("EventEntityUserEntity");
                });

            modelBuilder.Entity("ProjetoIntegrador.Domain.Entity.AddressEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Capacity")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Complement")
                        .HasColumnType("text");

                    b.Property<long>("CrecheId")
                        .HasColumnType("bigint");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<string>("Responsible")
                        .HasColumnType("text");

                    b.Property<string>("ResponsibleEmail")
                        .HasColumnType("text");

                    b.Property<string>("ResponsiblePhone")
                        .HasColumnType("text");

                    b.Property<string>("Schedule")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CrecheId");

                    b.HasIndex("UserId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("ProjetoIntegrador.Domain.Entity.CrecheEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Creche", (string)null);
                });

            modelBuilder.Entity("ProjetoIntegrador.Domain.Entity.Creches.EventEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CrecheId")
                        .HasColumnType("bigint");

                    b.Property<DateOnly?>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CrecheId");

                    b.ToTable("Event", (string)null);
                });

            modelBuilder.Entity("ProjetoIntegrador.Domain.Entity.Professores.ProfessorEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CPF")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Professor", (string)null);
                });

            modelBuilder.Entity("ProjetoIntegrador.Domain.Entity.User.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CPF")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("AddressEntityProfessorEntity", b =>
                {
                    b.HasOne("ProjetoIntegrador.Domain.Entity.AddressEntity", null)
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoIntegrador.Domain.Entity.Professores.ProfessorEntity", null)
                        .WithMany()
                        .HasForeignKey("ProfessoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CrecheEntityUserEntity", b =>
                {
                    b.HasOne("ProjetoIntegrador.Domain.Entity.User.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("AdministradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoIntegrador.Domain.Entity.CrecheEntity", null)
                        .WithMany()
                        .HasForeignKey("CrechesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventEntityUserEntity", b =>
                {
                    b.HasOne("ProjetoIntegrador.Domain.Entity.Creches.EventEntity", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoIntegrador.Domain.Entity.User.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoIntegrador.Domain.Entity.AddressEntity", b =>
                {
                    b.HasOne("ProjetoIntegrador.Domain.Entity.CrecheEntity", "Creche")
                        .WithMany("Addresses")
                        .HasForeignKey("CrecheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoIntegrador.Domain.Entity.User.UserEntity", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creche");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjetoIntegrador.Domain.Entity.Creches.EventEntity", b =>
                {
                    b.HasOne("ProjetoIntegrador.Domain.Entity.CrecheEntity", "Creche")
                        .WithMany("Events")
                        .HasForeignKey("CrecheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creche");
                });

            modelBuilder.Entity("ProjetoIntegrador.Domain.Entity.CrecheEntity", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("ProjetoIntegrador.Domain.Entity.User.UserEntity", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}