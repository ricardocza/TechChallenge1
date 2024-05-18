using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechChallenge1.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("03bbeed2-79db-4d04-8d22-5f7399fbd04a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("04b0a9cd-7fd3-4ecf-9aa0-3a2bb3cf3092"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("1a0ff11d-3c4c-4f1a-a5eb-5e7921b1a5be"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("20a752cc-9fed-4495-bffd-57af59f41a2a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("24c2ea8d-f516-4c5a-9706-0a3a05114460"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("2adb7410-d10c-4d03-b355-ee5ac83b46c5"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("31aafc9d-33dd-4d54-8446-662eb61792b4"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("57342861-1127-4028-92c2-bded69fc4713"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("5fa9a197-430d-4039-9012-b1befcae2d04"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("614c1500-37cd-480d-9222-c73099385b48"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("641bec58-5f43-4050-b35d-db730977066a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("65a93ed5-05d6-4b78-8590-110b51571962"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("7bb3d506-48b5-406c-aa13-d44667075fa2"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("8a264b15-bf48-41e2-bb97-39e4ea6e5598"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("91f2391c-5a62-456c-a3ee-2f58224a21c7"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("96d606c6-81ec-4d1e-9c15-96b6a48c7782"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("98cc416d-e609-4b0f-a298-7b7b64e081bf"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("a7df5980-e024-48a9-9ab4-332a1c7edd8e"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("ab97087e-8073-4a7b-ba7a-6ff826357c05"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("b75b2f74-aa85-4af3-acdd-b68f9e4c723e"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("bb3a17cc-c20b-4d0f-987a-4d38ddb4c1ee"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("c4b75fee-9622-4060-8158-ffde35d9f772"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("cac38b0c-8472-40b4-927e-500ecf79f525"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("ddf5a4a4-badc-4f9b-aabd-758fc9343125"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("ea53d08c-030d-4f20-a323-840832caa7de"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("eeaf7be8-9a30-483d-b566-70bf4960a16a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("fe0b54d6-2161-4109-9c9f-c96e4503595a"));

            migrationBuilder.InsertData(
                schema: "TechChallenge1",
                table: "State",
                columns: new[] { "Id", "DDD", "Name" },
                values: new object[,]
                {
                    { new Guid("01ef1418-a000-42cb-8f94-302e66b56b6e"), 67, "Mato Grosso do Sul" },
                    { new Guid("0291ccce-74a7-428c-96ce-789bba8e47dc"), 62, "Goiás" },
                    { new Guid("048565af-a33b-4c09-a663-649b335adb55"), 22, "Rio de Janeiro" },
                    { new Guid("0d103939-94d1-417c-b548-a741e419f0d1"), 71, "Bahia" },
                    { new Guid("0d19a4bc-db32-47f7-8abd-8128db4f0ba2"), 33, "Minas Gerais" },
                    { new Guid("1b59e514-6b27-43a1-91f2-87f4ab7eba97"), 93, "Pará" },
                    { new Guid("1b9b5853-d9b1-4f6e-a44a-e533361f3a77"), 28, "Espírito Santo" },
                    { new Guid("1e2c67e9-e24d-4748-887f-47cf756bfd2e"), 11, "São Paulo" },
                    { new Guid("1e8a92fd-16bc-415d-a68b-e489499e5f59"), 84, "Rio Grande do Norte" },
                    { new Guid("20ada234-2122-4339-9b3a-a41a5c0fa7e2"), 21, "Rio de Janeiro" },
                    { new Guid("22e9d77f-7396-4304-884f-6887d9aec40c"), 53, "Rio Grande do Sul" },
                    { new Guid("2bd0ca35-697a-4ede-84f2-79b3850f36cd"), 27, "Espírito Santo" },
                    { new Guid("2bdd55c6-d014-480d-9608-ef252f9063e6"), 13, "São Paulo" },
                    { new Guid("2ccc34e9-3410-42b6-9d2e-149d51e0ef2d"), 69, "Rondônia" },
                    { new Guid("303358e3-1d33-49d7-b3b2-b0a7fce0c164"), 37, "Minas Gerais" },
                    { new Guid("3156f34c-6e51-4ca2-a403-d7c08af19239"), 18, "São Paulo" },
                    { new Guid("3295c83f-1406-4734-b5a2-f7014ae7ec0c"), 74, "Bahia" },
                    { new Guid("38cdf9ea-fd6d-42fa-a5ac-5790af37325b"), 99, "Maranhão" },
                    { new Guid("41d5b95c-0ae6-4097-baa7-147472621725"), 66, "Mato Grosso" },
                    { new Guid("422afa85-3cd7-4adc-9b47-211e55c499e9"), 19, "São Paulo" },
                    { new Guid("438d587f-e71e-4848-a9d1-a641b6c4b8f8"), 96, "Amapá" },
                    { new Guid("43b61bcf-ebf4-4eff-8cb6-a57228c6faaf"), 65, "Mato Grosso" },
                    { new Guid("448f8e48-84e2-42b9-b614-fc45a83c3555"), 87, "Pernambuco" },
                    { new Guid("488598ec-6142-4c41-a08b-cc10ecf4371f"), 89, "Piauí" },
                    { new Guid("533e3b04-794a-4396-9a30-4811819d01de"), 16, "São Paulo" },
                    { new Guid("5b0195a7-5b54-4616-9e0a-6dc99c951b27"), 61, "Distrito Federal" },
                    { new Guid("5b0f60ac-51e2-4e22-8fc5-2055c7902cc0"), 75, "Bahia" },
                    { new Guid("5b53c41e-45aa-4bf6-b23f-91d9070c15cd"), 88, "Ceará" },
                    { new Guid("5bcd3815-941c-40b4-abc9-d8e63d1321d8"), 73, "Bahia" },
                    { new Guid("671fcea5-97d8-4364-bdc3-f184204f5536"), 17, "São Paulo" },
                    { new Guid("708e5e24-328f-4b66-95b2-82e6da62cfe7"), 49, "Santa Catarina" },
                    { new Guid("711d85d5-369c-443d-87ed-3b37782ba98a"), 41, "Paraná" },
                    { new Guid("73c1ab05-261b-4cd8-91b8-319035105245"), 64, "Goiás" },
                    { new Guid("7543e2ab-4ec4-4763-b635-e33cbf6b7d30"), 92, "Amazonas" },
                    { new Guid("792b1786-8b49-4060-aeed-44e623279ffa"), 47, "Santa Catarina" },
                    { new Guid("79a2db27-86a0-4a42-a739-c84927bdde06"), 79, "Sergipe" },
                    { new Guid("868460e5-da8c-49f1-8a9d-fbc8d1d499ae"), 31, "Minas Gerais" },
                    { new Guid("89396a0e-b116-4ccd-a917-6473f2b79082"), 63, "Tocantins" },
                    { new Guid("8b007c2a-81dd-4361-ae8b-a05fe74a02b5"), 43, "Paraná" },
                    { new Guid("8b153a1c-24ef-40fd-8c72-eb2a9a7970b0"), 46, "Paraná" },
                    { new Guid("8b7fa5f7-9d73-4161-a8f3-1d4158c65ac4"), 94, "Pará" },
                    { new Guid("93a19b1c-abd1-467f-b18b-3e4d42a2bac6"), 97, "Amazonas" },
                    { new Guid("94580211-4587-4aa4-9024-7d2bcf32bca9"), 91, "Pará" },
                    { new Guid("96f07d83-8115-4d31-ba8f-af570a4e1a21"), 38, "Minas Gerais" },
                    { new Guid("98d53bb2-cf39-42b3-92e7-a120c3a173ae"), 51, "Rio Grande do Sul" },
                    { new Guid("9a918991-934e-42cf-926c-0a8439baf1a6"), 77, "Bahia" },
                    { new Guid("a1fdffbb-b69f-4c33-af2d-2de67ea0e138"), 44, "Paraná" },
                    { new Guid("a368410c-1ee4-4354-82b2-01600cc123f6"), 98, "Maranhão" },
                    { new Guid("a3d6acae-af99-4ec8-84c6-df2e4e9d1b47"), 55, "Rio Grande do Sul" },
                    { new Guid("b3512937-1417-44be-a4ff-95046548561e"), 83, "Paraíba" },
                    { new Guid("b5eac9da-18ee-4608-88c4-5ba4b543a8cf"), 86, "Piauí" },
                    { new Guid("b64adb31-ae89-48d0-915f-fef5ab37a691"), 15, "São Paulo" },
                    { new Guid("ba0cdefc-0c5e-441b-87bf-55be573eb03f"), 81, "Pernambuco" },
                    { new Guid("be760d7f-02b7-4892-bad2-22b335754224"), 24, "Rio de Janeiro" },
                    { new Guid("beb818b0-0992-49e1-b1ba-fdee659a7235"), 32, "Minas Gerais" },
                    { new Guid("cb4661bd-2684-4e97-a816-0dba50eb2b9f"), 82, "Alagoas" },
                    { new Guid("d2cc660f-5644-4299-bac3-1d6d3f35ed3c"), 12, "São Paulo" },
                    { new Guid("d58f849b-1a64-4cfd-a6a7-ecb1db6e55b7"), 42, "Paraná" },
                    { new Guid("df7db0a6-7200-4cba-adc0-ce9ad80d1e95"), 48, "Santa Catarina" },
                    { new Guid("efe607fb-ccaa-444a-ad4f-7cce1f1cd4e1"), 34, "Minas Gerais" },
                    { new Guid("efec028f-2744-4885-83d0-31416b9125fe"), 35, "Minas Gerais" },
                    { new Guid("f287adc7-a6f9-4e70-93d9-5f0f1ee6e8cf"), 54, "Rio Grande do Sul" },
                    { new Guid("f5e1c7fe-624d-40df-b1cf-50d5d763631c"), 85, "Ceará" },
                    { new Guid("f7386a1c-fb66-4f27-b9ee-dde76d5bb3ee"), 95, "Roraima" },
                    { new Guid("fc6d6f3c-bccf-4942-82e3-fd4cb6dbcf3d"), 45, "Paraná" },
                    { new Guid("fda86ef7-307d-43ae-b2fe-1f2db8238f92"), 14, "São Paulo" },
                    { new Guid("fe69b678-aaf7-41a7-8fdc-f901894f256f"), 68, "Acre" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("01ef1418-a000-42cb-8f94-302e66b56b6e"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("0291ccce-74a7-428c-96ce-789bba8e47dc"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("048565af-a33b-4c09-a663-649b335adb55"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("0d103939-94d1-417c-b548-a741e419f0d1"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("0d19a4bc-db32-47f7-8abd-8128db4f0ba2"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("1b59e514-6b27-43a1-91f2-87f4ab7eba97"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("1b9b5853-d9b1-4f6e-a44a-e533361f3a77"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("1e2c67e9-e24d-4748-887f-47cf756bfd2e"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("1e8a92fd-16bc-415d-a68b-e489499e5f59"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("20ada234-2122-4339-9b3a-a41a5c0fa7e2"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("22e9d77f-7396-4304-884f-6887d9aec40c"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("2bd0ca35-697a-4ede-84f2-79b3850f36cd"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("2bdd55c6-d014-480d-9608-ef252f9063e6"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("2ccc34e9-3410-42b6-9d2e-149d51e0ef2d"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("303358e3-1d33-49d7-b3b2-b0a7fce0c164"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("3156f34c-6e51-4ca2-a403-d7c08af19239"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("3295c83f-1406-4734-b5a2-f7014ae7ec0c"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("38cdf9ea-fd6d-42fa-a5ac-5790af37325b"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("41d5b95c-0ae6-4097-baa7-147472621725"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("422afa85-3cd7-4adc-9b47-211e55c499e9"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("438d587f-e71e-4848-a9d1-a641b6c4b8f8"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("43b61bcf-ebf4-4eff-8cb6-a57228c6faaf"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("448f8e48-84e2-42b9-b614-fc45a83c3555"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("488598ec-6142-4c41-a08b-cc10ecf4371f"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("533e3b04-794a-4396-9a30-4811819d01de"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("5b0195a7-5b54-4616-9e0a-6dc99c951b27"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("5b0f60ac-51e2-4e22-8fc5-2055c7902cc0"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("5b53c41e-45aa-4bf6-b23f-91d9070c15cd"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("5bcd3815-941c-40b4-abc9-d8e63d1321d8"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("671fcea5-97d8-4364-bdc3-f184204f5536"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("708e5e24-328f-4b66-95b2-82e6da62cfe7"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("711d85d5-369c-443d-87ed-3b37782ba98a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("73c1ab05-261b-4cd8-91b8-319035105245"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("7543e2ab-4ec4-4763-b635-e33cbf6b7d30"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("792b1786-8b49-4060-aeed-44e623279ffa"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("79a2db27-86a0-4a42-a739-c84927bdde06"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("868460e5-da8c-49f1-8a9d-fbc8d1d499ae"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("89396a0e-b116-4ccd-a917-6473f2b79082"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("8b007c2a-81dd-4361-ae8b-a05fe74a02b5"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("8b153a1c-24ef-40fd-8c72-eb2a9a7970b0"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("8b7fa5f7-9d73-4161-a8f3-1d4158c65ac4"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("93a19b1c-abd1-467f-b18b-3e4d42a2bac6"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("94580211-4587-4aa4-9024-7d2bcf32bca9"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("96f07d83-8115-4d31-ba8f-af570a4e1a21"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("98d53bb2-cf39-42b3-92e7-a120c3a173ae"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("9a918991-934e-42cf-926c-0a8439baf1a6"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("a1fdffbb-b69f-4c33-af2d-2de67ea0e138"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("a368410c-1ee4-4354-82b2-01600cc123f6"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("a3d6acae-af99-4ec8-84c6-df2e4e9d1b47"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("b3512937-1417-44be-a4ff-95046548561e"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("b5eac9da-18ee-4608-88c4-5ba4b543a8cf"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("b64adb31-ae89-48d0-915f-fef5ab37a691"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("ba0cdefc-0c5e-441b-87bf-55be573eb03f"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("be760d7f-02b7-4892-bad2-22b335754224"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("beb818b0-0992-49e1-b1ba-fdee659a7235"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("cb4661bd-2684-4e97-a816-0dba50eb2b9f"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("d2cc660f-5644-4299-bac3-1d6d3f35ed3c"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("d58f849b-1a64-4cfd-a6a7-ecb1db6e55b7"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("df7db0a6-7200-4cba-adc0-ce9ad80d1e95"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("efe607fb-ccaa-444a-ad4f-7cce1f1cd4e1"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("efec028f-2744-4885-83d0-31416b9125fe"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("f287adc7-a6f9-4e70-93d9-5f0f1ee6e8cf"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("f5e1c7fe-624d-40df-b1cf-50d5d763631c"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("f7386a1c-fb66-4f27-b9ee-dde76d5bb3ee"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("fc6d6f3c-bccf-4942-82e3-fd4cb6dbcf3d"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("fda86ef7-307d-43ae-b2fe-1f2db8238f92"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("fe69b678-aaf7-41a7-8fdc-f901894f256f"));

            migrationBuilder.InsertData(
                schema: "TechChallenge1",
                table: "State",
                columns: new[] { "Id", "DDD", "Name" },
                values: new object[,]
                {
                    { new Guid("03bbeed2-79db-4d04-8d22-5f7399fbd04a"), 98, "São Luís" },
                    { new Guid("04b0a9cd-7fd3-4ecf-9aa0-3a2bb3cf3092"), 51, "Porto Alegre" },
                    { new Guid("1a0ff11d-3c4c-4f1a-a5eb-5e7921b1a5be"), 41, "Curitiba" },
                    { new Guid("20a752cc-9fed-4495-bffd-57af59f41a2a"), 95, "Boa Vista" },
                    { new Guid("24c2ea8d-f516-4c5a-9706-0a3a05114460"), 82, "Maceió" },
                    { new Guid("2adb7410-d10c-4d03-b355-ee5ac83b46c5"), 96, "Macapá" },
                    { new Guid("31aafc9d-33dd-4d54-8446-662eb61792b4"), 63, "Palmas" },
                    { new Guid("57342861-1127-4028-92c2-bded69fc4713"), 11, "São Paulo" },
                    { new Guid("5fa9a197-430d-4039-9012-b1befcae2d04"), 79, "Aracaju" },
                    { new Guid("614c1500-37cd-480d-9222-c73099385b48"), 67, "Campo Grande" },
                    { new Guid("641bec58-5f43-4050-b35d-db730977066a"), 69, "Porto Velho" },
                    { new Guid("65a93ed5-05d6-4b78-8590-110b51571962"), 84, "Natal" },
                    { new Guid("7bb3d506-48b5-406c-aa13-d44667075fa2"), 48, "Florianópolis" },
                    { new Guid("8a264b15-bf48-41e2-bb97-39e4ea6e5598"), 81, "Recife" },
                    { new Guid("91f2391c-5a62-456c-a3ee-2f58224a21c7"), 83, "João Pessoa" },
                    { new Guid("96d606c6-81ec-4d1e-9c15-96b6a48c7782"), 68, "Rio Branco" },
                    { new Guid("98cc416d-e609-4b0f-a298-7b7b64e081bf"), 71, "Salvador" },
                    { new Guid("a7df5980-e024-48a9-9ab4-332a1c7edd8e"), 86, "Teresina" },
                    { new Guid("ab97087e-8073-4a7b-ba7a-6ff826357c05"), 92, "Manaus" },
                    { new Guid("b75b2f74-aa85-4af3-acdd-b68f9e4c723e"), 85, "Fortaleza" },
                    { new Guid("bb3a17cc-c20b-4d0f-987a-4d38ddb4c1ee"), 61, "Brasília" },
                    { new Guid("c4b75fee-9622-4060-8158-ffde35d9f772"), 31, "Belo Horizonte" },
                    { new Guid("cac38b0c-8472-40b4-927e-500ecf79f525"), 62, "Goiânia" },
                    { new Guid("ddf5a4a4-badc-4f9b-aabd-758fc9343125"), 65, "Cuiabá" },
                    { new Guid("ea53d08c-030d-4f20-a323-840832caa7de"), 21, "Rio de Janeiro" },
                    { new Guid("eeaf7be8-9a30-483d-b566-70bf4960a16a"), 22, "Vitória" },
                    { new Guid("fe0b54d6-2161-4109-9c9f-c96e4503595a"), 91, "Belém" }
                });
        }
    }
}
