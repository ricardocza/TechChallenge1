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
    [Migration("20240518210608_Update001")]
    partial class Update001
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
                            Id = new Guid("1e2c67e9-e24d-4748-887f-47cf756bfd2e"),
                            DDD = 11,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("d2cc660f-5644-4299-bac3-1d6d3f35ed3c"),
                            DDD = 12,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("2bdd55c6-d014-480d-9608-ef252f9063e6"),
                            DDD = 13,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("fda86ef7-307d-43ae-b2fe-1f2db8238f92"),
                            DDD = 14,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("b64adb31-ae89-48d0-915f-fef5ab37a691"),
                            DDD = 15,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("533e3b04-794a-4396-9a30-4811819d01de"),
                            DDD = 16,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("671fcea5-97d8-4364-bdc3-f184204f5536"),
                            DDD = 17,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("3156f34c-6e51-4ca2-a403-d7c08af19239"),
                            DDD = 18,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("422afa85-3cd7-4adc-9b47-211e55c499e9"),
                            DDD = 19,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("20ada234-2122-4339-9b3a-a41a5c0fa7e2"),
                            DDD = 21,
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("048565af-a33b-4c09-a663-649b335adb55"),
                            DDD = 22,
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("be760d7f-02b7-4892-bad2-22b335754224"),
                            DDD = 24,
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("2bd0ca35-697a-4ede-84f2-79b3850f36cd"),
                            DDD = 27,
                            Name = "Espírito Santo"
                        },
                        new
                        {
                            Id = new Guid("1b9b5853-d9b1-4f6e-a44a-e533361f3a77"),
                            DDD = 28,
                            Name = "Espírito Santo"
                        },
                        new
                        {
                            Id = new Guid("868460e5-da8c-49f1-8a9d-fbc8d1d499ae"),
                            DDD = 31,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("beb818b0-0992-49e1-b1ba-fdee659a7235"),
                            DDD = 32,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("0d19a4bc-db32-47f7-8abd-8128db4f0ba2"),
                            DDD = 33,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("efe607fb-ccaa-444a-ad4f-7cce1f1cd4e1"),
                            DDD = 34,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("efec028f-2744-4885-83d0-31416b9125fe"),
                            DDD = 35,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("303358e3-1d33-49d7-b3b2-b0a7fce0c164"),
                            DDD = 37,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("96f07d83-8115-4d31-ba8f-af570a4e1a21"),
                            DDD = 38,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("711d85d5-369c-443d-87ed-3b37782ba98a"),
                            DDD = 41,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("d58f849b-1a64-4cfd-a6a7-ecb1db6e55b7"),
                            DDD = 42,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("8b007c2a-81dd-4361-ae8b-a05fe74a02b5"),
                            DDD = 43,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("a1fdffbb-b69f-4c33-af2d-2de67ea0e138"),
                            DDD = 44,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("fc6d6f3c-bccf-4942-82e3-fd4cb6dbcf3d"),
                            DDD = 45,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("8b153a1c-24ef-40fd-8c72-eb2a9a7970b0"),
                            DDD = 46,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("792b1786-8b49-4060-aeed-44e623279ffa"),
                            DDD = 47,
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Id = new Guid("df7db0a6-7200-4cba-adc0-ce9ad80d1e95"),
                            DDD = 48,
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Id = new Guid("708e5e24-328f-4b66-95b2-82e6da62cfe7"),
                            DDD = 49,
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Id = new Guid("98d53bb2-cf39-42b3-92e7-a120c3a173ae"),
                            DDD = 51,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("22e9d77f-7396-4304-884f-6887d9aec40c"),
                            DDD = 53,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("f287adc7-a6f9-4e70-93d9-5f0f1ee6e8cf"),
                            DDD = 54,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("a3d6acae-af99-4ec8-84c6-df2e4e9d1b47"),
                            DDD = 55,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("5b0195a7-5b54-4616-9e0a-6dc99c951b27"),
                            DDD = 61,
                            Name = "Distrito Federal"
                        },
                        new
                        {
                            Id = new Guid("0291ccce-74a7-428c-96ce-789bba8e47dc"),
                            DDD = 62,
                            Name = "Goiás"
                        },
                        new
                        {
                            Id = new Guid("73c1ab05-261b-4cd8-91b8-319035105245"),
                            DDD = 64,
                            Name = "Goiás"
                        },
                        new
                        {
                            Id = new Guid("89396a0e-b116-4ccd-a917-6473f2b79082"),
                            DDD = 63,
                            Name = "Tocantins"
                        },
                        new
                        {
                            Id = new Guid("43b61bcf-ebf4-4eff-8cb6-a57228c6faaf"),
                            DDD = 65,
                            Name = "Mato Grosso"
                        },
                        new
                        {
                            Id = new Guid("41d5b95c-0ae6-4097-baa7-147472621725"),
                            DDD = 66,
                            Name = "Mato Grosso"
                        },
                        new
                        {
                            Id = new Guid("01ef1418-a000-42cb-8f94-302e66b56b6e"),
                            DDD = 67,
                            Name = "Mato Grosso do Sul"
                        },
                        new
                        {
                            Id = new Guid("fe69b678-aaf7-41a7-8fdc-f901894f256f"),
                            DDD = 68,
                            Name = "Acre"
                        },
                        new
                        {
                            Id = new Guid("2ccc34e9-3410-42b6-9d2e-149d51e0ef2d"),
                            DDD = 69,
                            Name = "Rondônia"
                        },
                        new
                        {
                            Id = new Guid("0d103939-94d1-417c-b548-a741e419f0d1"),
                            DDD = 71,
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("5bcd3815-941c-40b4-abc9-d8e63d1321d8"),
                            DDD = 73,
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("3295c83f-1406-4734-b5a2-f7014ae7ec0c"),
                            DDD = 74,
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("5b0f60ac-51e2-4e22-8fc5-2055c7902cc0"),
                            DDD = 75,
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("9a918991-934e-42cf-926c-0a8439baf1a6"),
                            DDD = 77,
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("79a2db27-86a0-4a42-a739-c84927bdde06"),
                            DDD = 79,
                            Name = "Sergipe"
                        },
                        new
                        {
                            Id = new Guid("ba0cdefc-0c5e-441b-87bf-55be573eb03f"),
                            DDD = 81,
                            Name = "Pernambuco"
                        },
                        new
                        {
                            Id = new Guid("448f8e48-84e2-42b9-b614-fc45a83c3555"),
                            DDD = 87,
                            Name = "Pernambuco"
                        },
                        new
                        {
                            Id = new Guid("b5eac9da-18ee-4608-88c4-5ba4b543a8cf"),
                            DDD = 86,
                            Name = "Piauí"
                        },
                        new
                        {
                            Id = new Guid("488598ec-6142-4c41-a08b-cc10ecf4371f"),
                            DDD = 89,
                            Name = "Piauí"
                        },
                        new
                        {
                            Id = new Guid("cb4661bd-2684-4e97-a816-0dba50eb2b9f"),
                            DDD = 82,
                            Name = "Alagoas"
                        },
                        new
                        {
                            Id = new Guid("b3512937-1417-44be-a4ff-95046548561e"),
                            DDD = 83,
                            Name = "Paraíba"
                        },
                        new
                        {
                            Id = new Guid("1e8a92fd-16bc-415d-a68b-e489499e5f59"),
                            DDD = 84,
                            Name = "Rio Grande do Norte"
                        },
                        new
                        {
                            Id = new Guid("f5e1c7fe-624d-40df-b1cf-50d5d763631c"),
                            DDD = 85,
                            Name = "Ceará"
                        },
                        new
                        {
                            Id = new Guid("5b53c41e-45aa-4bf6-b23f-91d9070c15cd"),
                            DDD = 88,
                            Name = "Ceará"
                        },
                        new
                        {
                            Id = new Guid("438d587f-e71e-4848-a9d1-a641b6c4b8f8"),
                            DDD = 96,
                            Name = "Amapá"
                        },
                        new
                        {
                            Id = new Guid("7543e2ab-4ec4-4763-b635-e33cbf6b7d30"),
                            DDD = 92,
                            Name = "Amazonas"
                        },
                        new
                        {
                            Id = new Guid("93a19b1c-abd1-467f-b18b-3e4d42a2bac6"),
                            DDD = 97,
                            Name = "Amazonas"
                        },
                        new
                        {
                            Id = new Guid("94580211-4587-4aa4-9024-7d2bcf32bca9"),
                            DDD = 91,
                            Name = "Pará"
                        },
                        new
                        {
                            Id = new Guid("1b59e514-6b27-43a1-91f2-87f4ab7eba97"),
                            DDD = 93,
                            Name = "Pará"
                        },
                        new
                        {
                            Id = new Guid("8b7fa5f7-9d73-4161-a8f3-1d4158c65ac4"),
                            DDD = 94,
                            Name = "Pará"
                        },
                        new
                        {
                            Id = new Guid("f7386a1c-fb66-4f27-b9ee-dde76d5bb3ee"),
                            DDD = 95,
                            Name = "Roraima"
                        },
                        new
                        {
                            Id = new Guid("a368410c-1ee4-4354-82b2-01600cc123f6"),
                            DDD = 98,
                            Name = "Maranhão"
                        },
                        new
                        {
                            Id = new Guid("38cdf9ea-fd6d-42fa-a5ac-5790af37325b"),
                            DDD = 99,
                            Name = "Maranhão"
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
