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
                    { new Guid("057e3f0a-8ee2-4bbf-afd7-aabdd9c89291"), 11, "São Paulo" },
                    { new Guid("0e713c33-8d65-424d-90c7-bef3eac6e180"), 95, "Boa Vista" },
                    { new Guid("151e4972-eebb-4d42-af90-e43b892b3398"), 61, "Brasília" },
                    { new Guid("16f0cfe1-989c-4643-a750-0639f00641f7"), 41, "Curitiba" },
                    { new Guid("18cec7ef-481e-4b5b-bb82-b1a68576c7ec"), 91, "Belém" },
                    { new Guid("1a7e0bac-647a-46c5-99ed-6da690cc6343"), 65, "Cuiabá" },
                    { new Guid("35f8abcb-4c52-400b-9659-3ddcbc960744"), 48, "Florianópolis" },
                    { new Guid("391b8450-a646-403e-880b-cf19e5482768"), 68, "Rio Branco" },
                    { new Guid("4510a7dd-b8a5-4f83-bf8c-511d98826f97"), 98, "São Luís" },
                    { new Guid("6581ab83-fac6-4b69-91cb-daf4ee24da39"), 69, "Porto Velho" },
                    { new Guid("6b7056a2-9e02-412f-b8c7-52b48484596a"), 84, "Natal" },
                    { new Guid("7231c076-d737-404f-a17d-880210f33d67"), 71, "Salvador" },
                    { new Guid("7584c8f3-5a1f-4a4d-bab0-f46422ad7c8d"), 92, "Manaus" },
                    { new Guid("76c2b443-183e-47b7-9f5a-7b0abfb9c86b"), 63, "Palmas" },
                    { new Guid("78b89ae2-0568-4cb4-8ec4-8765e11d5a63"), 96, "Macapá" },
                    { new Guid("7e2e0415-fc56-4790-92b5-7106c584296e"), 79, "Aracaju" },
                    { new Guid("8281c06a-386f-41e6-a3eb-4a47116ecd55"), 81, "Recife" },
                    { new Guid("89f6cd24-86ee-4e8d-9822-5ea63cdd2db3"), 83, "João Pessoa" },
                    { new Guid("8ae53368-db49-417c-8810-25e4de5291e4"), 82, "Maceió" },
                    { new Guid("8e0af3e5-548e-475b-9a68-f4ae98b3e5a8"), 21, "Rio de Janeiro" },
                    { new Guid("a1bbee87-6805-4ee2-a07b-4027d7353765"), 31, "Belo Horizonte" },
                    { new Guid("a8302dea-becf-401f-8820-7ba4e4ed8638"), 62, "Goiânia" },
                    { new Guid("ab5fbc48-e0d5-44eb-9189-47fe15f9f576"), 22, "Vitória" },
                    { new Guid("cec1b553-fdcc-497e-aa9f-117f3598a55f"), 51, "Porto Alegre" },
                    { new Guid("d834c85d-b467-4eb4-b2e8-59f3517a18df"), 86, "Teresina" },
                    { new Guid("da0d0447-10e7-4905-a020-b61eb947fbc7"), 85, "Fortaleza" },
                    { new Guid("fb8f29b9-a17e-46e1-9299-4b765a16d647"), 67, "Campo Grande" }
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
