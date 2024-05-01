using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechChallenge1.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    StateId = table.Column<int>(type: "INT", nullable: false)
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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11, "11 - São Paulo" },
                    { 21, "21 - Rio de Janeiro" },
                    { 22, "27 - Vitória" },
                    { 31, "31 - Belo Horizonte" },
                    { 41, "41 - Curitiba" },
                    { 48, "48 - Florianópolis" },
                    { 51, "51 - Porto Alegre" },
                    { 61, "61 - Brasília" },
                    { 62, "62 - Goiânia" },
                    { 63, "63 - Palmas" },
                    { 65, "65 - Cuiabá" },
                    { 67, "67 - Campo Grande" },
                    { 68, "68 - Rio Branco" },
                    { 69, "69 - Porto Velho" },
                    { 71, "71 - Salvador" },
                    { 79, "79 - Aracaju" },
                    { 81, "81 - Recife" },
                    { 82, "82 - Maceió" },
                    { 83, "83 - João Pessoa" },
                    { 84, "84 - Natal" },
                    { 85, "85 - Fortaleza" },
                    { 86, "86 - Teresina" },
                    { 91, "91 - Belém" },
                    { 92, "92 - Manaus" },
                    { 95, "95 - Boa Vista" },
                    { 96, "96 - Macapá" },
                    { 98, "98 - São Luís" }
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
