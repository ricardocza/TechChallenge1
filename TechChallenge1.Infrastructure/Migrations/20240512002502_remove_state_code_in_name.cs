using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechChallenge1.Data.Migrations
{
    /// <inheritdoc />
    public partial class remove_state_code_in_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("07a0c26f-80c2-4caa-aa11-fbc23720f911"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("1064a30a-4230-40d4-8e7e-b6552214fd4a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("117d05e9-48b2-41d9-bb86-cf030954133e"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("16f8b52d-0858-4398-ba13-482191adc44e"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("26b8789d-85f7-4fd8-ab8d-99a77f7dc2de"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("37ecae54-d0ac-41b2-9c8a-219c3d10583a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("3f900447-a62f-4698-be0a-283ea7571b4f"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("453ce548-b73e-48a2-9413-8d0df2bec509"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("46c18361-0a5b-45cf-ade7-c4d8611a0300"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("499d33d6-aae4-42ca-b876-c5fdaa52aa28"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("543d43c4-315f-4117-a2b3-e202509e1c69"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("5c12ed7f-2eae-45cc-9111-5a4d246a0a39"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("602ef38a-3a3f-4765-8d01-42ac8a15f319"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("623ab703-b5f1-4208-a4aa-82de97eb696b"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("7de5130e-1112-467d-a010-f9a9b04ba8ab"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("9350fcf1-8d37-4af8-a1bb-34b2482059c4"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("9976f5a2-8d88-4b2e-b7b0-ae6a531e35a4"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("a12e88a2-5d60-4646-9373-0eda16ade298"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("a3b9a17f-0900-4796-9122-2c6722845a6a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("a97521e0-69ed-4471-b55a-7605235488db"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("b2eb2523-b7c5-484f-8979-7b59035f0946"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("c076a959-b0fc-488b-871c-e6d60964ad8d"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("c20f03ac-13d1-4ac5-b31a-710c11133bc8"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("d5541227-d002-47a1-81f4-2577ba036c56"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("da824844-3651-4a4f-976b-d568e534783e"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("df062898-4164-41bf-83f2-7522a4aff655"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("ffe7cddc-b27f-4908-87cd-4ff6ec0bfc10"));

            migrationBuilder.InsertData(
                schema: "TechChallenge1",
                table: "State",
                columns: new[] { "Id", "DDD", "Name" },
                values: new object[,]
                {
                    { new Guid("1bad00ac-11c9-4f2d-8c76-c528255f7cb1"), 21, "Rio de Janeiro" },
                    { new Guid("1f117634-5a80-4c0e-9ac6-52c0d8ad723a"), 51, "Porto Alegre" },
                    { new Guid("2a1fecbf-2878-49df-a61b-258227145cfa"), 11, "São Paulo" },
                    { new Guid("2c1cd8ab-4528-4575-90d7-2fb6af3c3e96"), 22, "Vitória" },
                    { new Guid("2fea6eec-a7c6-42f3-beab-841768d28321"), 61, "Brasília" },
                    { new Guid("38fd25bc-22ac-4f8b-ab19-a3c04550141c"), 67, "Campo Grande" },
                    { new Guid("593c81ff-7bb6-4ce7-aee5-d16e5e6fb169"), 69, "Porto Velho" },
                    { new Guid("5e042064-b48f-4cbf-a308-9ca9a6c0122b"), 86, "Teresina" },
                    { new Guid("6003f96e-2901-473f-b2a7-d4a6fc2dea6d"), 92, "Manaus" },
                    { new Guid("6d6ae363-d0ec-42ee-a680-1eccf0611bc9"), 95, "Boa Vista" },
                    { new Guid("6f67473f-bab4-4c53-b02c-a9698b512ce4"), 71, "Salvador" },
                    { new Guid("730ab5cd-e083-4c75-bfc7-1f3d235d7333"), 68, "Rio Branco" },
                    { new Guid("79934626-7e38-491d-bef6-0fd6193fc54c"), 81, "Recife" },
                    { new Guid("98d4fa8d-83fc-498a-9f10-4dbb0338cd0b"), 79, "Aracaju" },
                    { new Guid("a3eee062-09fa-410b-b3e7-716710394894"), 41, "Curitiba" },
                    { new Guid("aff4abc7-8083-475a-b08a-536afb72aa2e"), 65, "Cuiabá" },
                    { new Guid("b68927a8-3866-4559-9b02-91720faca06a"), 48, "Florianópolis" },
                    { new Guid("bfc977c9-b92a-4d7f-a935-7afc077998de"), 98, "São Luís" },
                    { new Guid("c145e976-b48a-4e83-b590-f574a57827f6"), 84, "Natal" },
                    { new Guid("c738d766-807a-4bd6-8a25-4d7d47367a42"), 85, "Fortaleza" },
                    { new Guid("d2a7cbc6-0f75-4519-b852-f4a6c84472e0"), 31, "Belo Horizonte" },
                    { new Guid("d73142bd-d616-4e22-9877-441f2be4309a"), 83, "João Pessoa" },
                    { new Guid("e28d40ef-cc88-4742-bf07-1174bb4d37cd"), 62, "Goiânia" },
                    { new Guid("e63491ad-486a-4d30-a69a-9de2ef9e7526"), 96, "Macapá" },
                    { new Guid("e747a2e5-4f2e-4790-afe3-7d47d073469a"), 63, "Palmas" },
                    { new Guid("ec6f3cb1-2260-4df4-b44e-694db64abb9b"), 91, "Belém" },
                    { new Guid("f5b87d2b-8cdd-4394-bb3b-d9334f89ce30"), 82, "Maceió" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("1bad00ac-11c9-4f2d-8c76-c528255f7cb1"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("1f117634-5a80-4c0e-9ac6-52c0d8ad723a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("2a1fecbf-2878-49df-a61b-258227145cfa"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("2c1cd8ab-4528-4575-90d7-2fb6af3c3e96"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("2fea6eec-a7c6-42f3-beab-841768d28321"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("38fd25bc-22ac-4f8b-ab19-a3c04550141c"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("593c81ff-7bb6-4ce7-aee5-d16e5e6fb169"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("5e042064-b48f-4cbf-a308-9ca9a6c0122b"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("6003f96e-2901-473f-b2a7-d4a6fc2dea6d"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("6d6ae363-d0ec-42ee-a680-1eccf0611bc9"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("6f67473f-bab4-4c53-b02c-a9698b512ce4"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("730ab5cd-e083-4c75-bfc7-1f3d235d7333"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("79934626-7e38-491d-bef6-0fd6193fc54c"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("98d4fa8d-83fc-498a-9f10-4dbb0338cd0b"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("a3eee062-09fa-410b-b3e7-716710394894"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("aff4abc7-8083-475a-b08a-536afb72aa2e"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("b68927a8-3866-4559-9b02-91720faca06a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("bfc977c9-b92a-4d7f-a935-7afc077998de"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("c145e976-b48a-4e83-b590-f574a57827f6"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("c738d766-807a-4bd6-8a25-4d7d47367a42"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("d2a7cbc6-0f75-4519-b852-f4a6c84472e0"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("d73142bd-d616-4e22-9877-441f2be4309a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("e28d40ef-cc88-4742-bf07-1174bb4d37cd"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("e63491ad-486a-4d30-a69a-9de2ef9e7526"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("e747a2e5-4f2e-4790-afe3-7d47d073469a"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("ec6f3cb1-2260-4df4-b44e-694db64abb9b"));

            migrationBuilder.DeleteData(
                schema: "TechChallenge1",
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("f5b87d2b-8cdd-4394-bb3b-d9334f89ce30"));

            migrationBuilder.InsertData(
                schema: "TechChallenge1",
                table: "State",
                columns: new[] { "Id", "DDD", "Name" },
                values: new object[,]
                {
                    { new Guid("07a0c26f-80c2-4caa-aa11-fbc23720f911"), 11, "11 - São Paulo" },
                    { new Guid("1064a30a-4230-40d4-8e7e-b6552214fd4a"), 67, "67 - Campo Grande" },
                    { new Guid("117d05e9-48b2-41d9-bb86-cf030954133e"), 21, "21 - Rio de Janeiro" },
                    { new Guid("16f8b52d-0858-4398-ba13-482191adc44e"), 91, "91 - Belém" },
                    { new Guid("26b8789d-85f7-4fd8-ab8d-99a77f7dc2de"), 81, "81 - Recife" },
                    { new Guid("37ecae54-d0ac-41b2-9c8a-219c3d10583a"), 84, "84 - Natal" },
                    { new Guid("3f900447-a62f-4698-be0a-283ea7571b4f"), 63, "63 - Palmas" },
                    { new Guid("453ce548-b73e-48a2-9413-8d0df2bec509"), 95, "95 - Boa Vista" },
                    { new Guid("46c18361-0a5b-45cf-ade7-c4d8611a0300"), 79, "79 - Aracaju" },
                    { new Guid("499d33d6-aae4-42ca-b876-c5fdaa52aa28"), 82, "82 - Maceió" },
                    { new Guid("543d43c4-315f-4117-a2b3-e202509e1c69"), 85, "85 - Fortaleza" },
                    { new Guid("5c12ed7f-2eae-45cc-9111-5a4d246a0a39"), 96, "96 - Macapá" },
                    { new Guid("602ef38a-3a3f-4765-8d01-42ac8a15f319"), 65, "65 - Cuiabá" },
                    { new Guid("623ab703-b5f1-4208-a4aa-82de97eb696b"), 98, "98 - São Luís" },
                    { new Guid("7de5130e-1112-467d-a010-f9a9b04ba8ab"), 61, "61 - Brasília" },
                    { new Guid("9350fcf1-8d37-4af8-a1bb-34b2482059c4"), 92, "92 - Manaus" },
                    { new Guid("9976f5a2-8d88-4b2e-b7b0-ae6a531e35a4"), 71, "71 - Salvador" },
                    { new Guid("a12e88a2-5d60-4646-9373-0eda16ade298"), 86, "86 - Teresina" },
                    { new Guid("a3b9a17f-0900-4796-9122-2c6722845a6a"), 51, "51 - Porto Alegre" },
                    { new Guid("a97521e0-69ed-4471-b55a-7605235488db"), 48, "48 - Florianópolis" },
                    { new Guid("b2eb2523-b7c5-484f-8979-7b59035f0946"), 41, "41 - Curitiba" },
                    { new Guid("c076a959-b0fc-488b-871c-e6d60964ad8d"), 68, "68 - Rio Branco" },
                    { new Guid("c20f03ac-13d1-4ac5-b31a-710c11133bc8"), 31, "31 - Belo Horizonte" },
                    { new Guid("d5541227-d002-47a1-81f4-2577ba036c56"), 83, "83 - João Pessoa" },
                    { new Guid("da824844-3651-4a4f-976b-d568e534783e"), 69, "69 - Porto Velho" },
                    { new Guid("df062898-4164-41bf-83f2-7522a4aff655"), 22, "27 - Vitória" },
                    { new Guid("ffe7cddc-b27f-4908-87cd-4ff6ec0bfc10"), 62, "62 - Goiânia" }
                });
        }
    }
}
