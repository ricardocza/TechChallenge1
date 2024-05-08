using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechChallenge1.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TechChallenge1");

            migrationBuilder.CreateTable(
                name: "State",
                schema: "TechChallenge1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DDD = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                schema: "TechChallenge1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "TechChallenge1",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Contact_StateId",
                schema: "TechChallenge1",
                table: "Contact",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact",
                schema: "TechChallenge1");

            migrationBuilder.DropTable(
                name: "State",
                schema: "TechChallenge1");
        }
    }
}
