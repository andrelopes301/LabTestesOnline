﻿// <auto-generated />
using System;
using LabTestesOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LabTestesOnline.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220114005508_migrationEstado")]
    partial class migrationEstado
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LabTestesOnline.Models.CentroAnalise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GestorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HorarioAbertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioEncerramento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumLimiteTestes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GestorId");

                    b.ToTable("CentrosAnalises");
                });

            modelBuilder.Entity("LabTestesOnline.Models.Teste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CentroAnaliseId")
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Resultado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TecnicoResponsavelId")
                        .HasColumnType("int");

                    b.Property<string>("TipoTeste")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CentroAnaliseId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("TecnicoResponsavelId");

                    b.ToTable("Testes");
                });

            modelBuilder.Entity("LabTestesOnline.Models.TestesPossiveis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CentroAnaliseId")
                        .HasColumnType("int");

                    b.Property<string>("TipoTeste")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CentroAnaliseId");

                    b.ToTable("TestesPossiveis");
                });

            modelBuilder.Entity("LabTestesOnline.Models.Utilizador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contacto")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Morada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Utilizador");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a9b54cf9-2715-4e7b-b95f-db77735b049b",
                            Contacto = 0,
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFXAfzzyNKMIUnMNk6hiWtASAKOzNgpwyKGPfha69yF2uIyWoRObiTuZS2NVpOAqwA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e4da11b9-e05a-40e1-98ea-334189536d27",
                            Sexo = " ",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "2",
                            Name = "Gestor",
                            NormalizedName = "GESTOR"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "3",
                            Name = "Tecnico",
                            NormalizedName = "TECNICO"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "4",
                            Name = "Cliente",
                            NormalizedName = "CLIENTE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LabTestesOnline.Models.Cliente", b =>
                {
                    b.HasBaseType("LabTestesOnline.Models.Utilizador");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("LabTestesOnline.Models.Gestor", b =>
                {
                    b.HasBaseType("LabTestesOnline.Models.Utilizador");

                    b.HasDiscriminator().HasValue("Gestor");
                });

            modelBuilder.Entity("LabTestesOnline.Models.Tecnico", b =>
                {
                    b.HasBaseType("LabTestesOnline.Models.Utilizador");

                    b.Property<int?>("CentroAnaliseId")
                        .HasColumnType("int");

                    b.HasIndex("CentroAnaliseId");

                    b.HasDiscriminator().HasValue("Tecnico");
                });

            modelBuilder.Entity("LabTestesOnline.Models.CentroAnalise", b =>
                {
                    b.HasOne("LabTestesOnline.Models.Gestor", "Gestor")
                        .WithMany("CentrosAnalises")
                        .HasForeignKey("GestorId");

                    b.Navigation("Gestor");
                });

            modelBuilder.Entity("LabTestesOnline.Models.Teste", b =>
                {
                    b.HasOne("LabTestesOnline.Models.CentroAnalise", "CentroAnalise")
                        .WithMany()
                        .HasForeignKey("CentroAnaliseId");

                    b.HasOne("LabTestesOnline.Models.Cliente", "Cliente")
                        .WithMany("Testes")
                        .HasForeignKey("ClienteId");

                    b.HasOne("LabTestesOnline.Models.Tecnico", "TecnicoResponsavel")
                        .WithMany()
                        .HasForeignKey("TecnicoResponsavelId");

                    b.Navigation("CentroAnalise");

                    b.Navigation("Cliente");

                    b.Navigation("TecnicoResponsavel");
                });

            modelBuilder.Entity("LabTestesOnline.Models.TestesPossiveis", b =>
                {
                    b.HasOne("LabTestesOnline.Models.CentroAnalise", "CentroAnalise")
                        .WithMany("TestesPossiveis")
                        .HasForeignKey("CentroAnaliseId");

                    b.Navigation("CentroAnalise");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("LabTestesOnline.Models.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("LabTestesOnline.Models.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabTestesOnline.Models.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("LabTestesOnline.Models.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LabTestesOnline.Models.Tecnico", b =>
                {
                    b.HasOne("LabTestesOnline.Models.CentroAnalise", "CentroAnalise")
                        .WithMany("Tecnicos")
                        .HasForeignKey("CentroAnaliseId");

                    b.Navigation("CentroAnalise");
                });

            modelBuilder.Entity("LabTestesOnline.Models.CentroAnalise", b =>
                {
                    b.Navigation("Tecnicos");

                    b.Navigation("TestesPossiveis");
                });

            modelBuilder.Entity("LabTestesOnline.Models.Cliente", b =>
                {
                    b.Navigation("Testes");
                });

            modelBuilder.Entity("LabTestesOnline.Models.Gestor", b =>
                {
                    b.Navigation("CentrosAnalises");
                });
#pragma warning restore 612, 618
        }
    }
}
