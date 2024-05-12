using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechChallenge1.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
