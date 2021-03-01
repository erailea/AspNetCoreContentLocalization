using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreContentLocalization.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cultures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalizationSets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalizationSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameId = table.Column<int>(nullable: false),
                    DescriptionId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_LocalizationSets_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "LocalizationSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_LocalizationSets_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "LocalizationSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_LocalizationSets_NameId",
                        column: x => x.NameId,
                        principalTable: "LocalizationSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Librarys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librarys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Librarys_LocalizationSets_NameId",
                        column: x => x.NameId,
                        principalTable: "LocalizationSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Localizations",
                columns: table => new
                {
                    LocalizationSetId = table.Column<int>(nullable: false),
                    CultureId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizations", x => new { x.LocalizationSetId, x.CultureId });
                    table.ForeignKey(
                        name: "FK_Localizations_Cultures_CultureId",
                        column: x => x.CultureId,
                        principalTable: "Cultures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Localizations_LocalizationSets_LocalizationSetId",
                        column: x => x.LocalizationSetId,
                        principalTable: "LocalizationSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cultures",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 1, "tr", "Türkçe" });

            migrationBuilder.InsertData(
                table: "Cultures",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 2, "en", "English" });

            migrationBuilder.InsertData(
                table: "Cultures",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 3, "de", "Deutsch" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_DescriptionId",
                table: "Books",
                column: "DescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_NameId",
                table: "Books",
                column: "NameId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Librarys_NameId",
                table: "Librarys",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_Localizations_CultureId",
                table: "Localizations",
                column: "CultureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Librarys");

            migrationBuilder.DropTable(
                name: "Localizations");

            migrationBuilder.DropTable(
                name: "Cultures");

            migrationBuilder.DropTable(
                name: "LocalizationSets");
        }
    }
}
