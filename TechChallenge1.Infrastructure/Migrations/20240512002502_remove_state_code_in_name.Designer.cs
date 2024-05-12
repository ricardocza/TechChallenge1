﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechChallenge1.Data.Context;

#nullable disable

namespace TechChallenge1.Data.Migrations
{
    [DbContext(typeof(techchallengeDbContext))]
    [Migration("20240512002502_remove_state_code_in_name")]
    partial class remove_state_code_in_name
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechChallenge1.Domain.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("StateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Contact", "TechChallenge1");
                });

            modelBuilder.Entity("TechChallenge1.Domain.Models.State", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DDD")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("State", "TechChallenge1");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2a1fecbf-2878-49df-a61b-258227145cfa"),
                            DDD = 11,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("1bad00ac-11c9-4f2d-8c76-c528255f7cb1"),
                            DDD = 21,
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("2c1cd8ab-4528-4575-90d7-2fb6af3c3e96"),
                            DDD = 22,
                            Name = "Vitória"
                        },
                        new
                        {
                            Id = new Guid("d2a7cbc6-0f75-4519-b852-f4a6c84472e0"),
                            DDD = 31,
                            Name = "Belo Horizonte"
                        },
                        new
                        {
                            Id = new Guid("a3eee062-09fa-410b-b3e7-716710394894"),
                            DDD = 41,
                            Name = "Curitiba"
                        },
                        new
                        {
                            Id = new Guid("b68927a8-3866-4559-9b02-91720faca06a"),
                            DDD = 48,
                            Name = "Florianópolis"
                        },
                        new
                        {
                            Id = new Guid("1f117634-5a80-4c0e-9ac6-52c0d8ad723a"),
                            DDD = 51,
                            Name = "Porto Alegre"
                        },
                        new
                        {
                            Id = new Guid("2fea6eec-a7c6-42f3-beab-841768d28321"),
                            DDD = 61,
                            Name = "Brasília"
                        },
                        new
                        {
                            Id = new Guid("e28d40ef-cc88-4742-bf07-1174bb4d37cd"),
                            DDD = 62,
                            Name = "Goiânia"
                        },
                        new
                        {
                            Id = new Guid("e747a2e5-4f2e-4790-afe3-7d47d073469a"),
                            DDD = 63,
                            Name = "Palmas"
                        },
                        new
                        {
                            Id = new Guid("aff4abc7-8083-475a-b08a-536afb72aa2e"),
                            DDD = 65,
                            Name = "Cuiabá"
                        },
                        new
                        {
                            Id = new Guid("38fd25bc-22ac-4f8b-ab19-a3c04550141c"),
                            DDD = 67,
                            Name = "Campo Grande"
                        },
                        new
                        {
                            Id = new Guid("730ab5cd-e083-4c75-bfc7-1f3d235d7333"),
                            DDD = 68,
                            Name = "Rio Branco"
                        },
                        new
                        {
                            Id = new Guid("593c81ff-7bb6-4ce7-aee5-d16e5e6fb169"),
                            DDD = 69,
                            Name = "Porto Velho"
                        },
                        new
                        {
                            Id = new Guid("6f67473f-bab4-4c53-b02c-a9698b512ce4"),
                            DDD = 71,
                            Name = "Salvador"
                        },
                        new
                        {
                            Id = new Guid("98d4fa8d-83fc-498a-9f10-4dbb0338cd0b"),
                            DDD = 79,
                            Name = "Aracaju"
                        },
                        new
                        {
                            Id = new Guid("79934626-7e38-491d-bef6-0fd6193fc54c"),
                            DDD = 81,
                            Name = "Recife"
                        },
                        new
                        {
                            Id = new Guid("f5b87d2b-8cdd-4394-bb3b-d9334f89ce30"),
                            DDD = 82,
                            Name = "Maceió"
                        },
                        new
                        {
                            Id = new Guid("d73142bd-d616-4e22-9877-441f2be4309a"),
                            DDD = 83,
                            Name = "João Pessoa"
                        },
                        new
                        {
                            Id = new Guid("c145e976-b48a-4e83-b590-f574a57827f6"),
                            DDD = 84,
                            Name = "Natal"
                        },
                        new
                        {
                            Id = new Guid("c738d766-807a-4bd6-8a25-4d7d47367a42"),
                            DDD = 85,
                            Name = "Fortaleza"
                        },
                        new
                        {
                            Id = new Guid("5e042064-b48f-4cbf-a308-9ca9a6c0122b"),
                            DDD = 86,
                            Name = "Teresina"
                        },
                        new
                        {
                            Id = new Guid("ec6f3cb1-2260-4df4-b44e-694db64abb9b"),
                            DDD = 91,
                            Name = "Belém"
                        },
                        new
                        {
                            Id = new Guid("6003f96e-2901-473f-b2a7-d4a6fc2dea6d"),
                            DDD = 92,
                            Name = "Manaus"
                        },
                        new
                        {
                            Id = new Guid("6d6ae363-d0ec-42ee-a680-1eccf0611bc9"),
                            DDD = 95,
                            Name = "Boa Vista"
                        },
                        new
                        {
                            Id = new Guid("e63491ad-486a-4d30-a69a-9de2ef9e7526"),
                            DDD = 96,
                            Name = "Macapá"
                        },
                        new
                        {
                            Id = new Guid("bfc977c9-b92a-4d7f-a935-7afc077998de"),
                            DDD = 98,
                            Name = "São Luís"
                        });
                });

            modelBuilder.Entity("TechChallenge1.Domain.Models.Contact", b =>
                {
                    b.HasOne("TechChallenge1.Domain.Models.State", "State")
                        .WithMany("Contacts")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("TechChallenge1.Domain.Models.State", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
