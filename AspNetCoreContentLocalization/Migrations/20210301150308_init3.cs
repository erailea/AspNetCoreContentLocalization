using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreContentLocalization.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocalizationSets_Books_AuthorId",
                table: "LocalizationSets");

            migrationBuilder.DropForeignKey(
                name: "FK_LocalizationSets_Books_DescriptionId",
                table: "LocalizationSets");

            migrationBuilder.DropForeignKey(
                name: "FK_LocalizationSets_Books_NameId",
                table: "LocalizationSets");

            migrationBuilder.DropIndex(
                name: "IX_LocalizationSets_AuthorId",
                table: "LocalizationSets");

            migrationBuilder.DropIndex(
                name: "IX_LocalizationSets_DescriptionId",
                table: "LocalizationSets");

            migrationBuilder.DropIndex(
                name: "IX_LocalizationSets_NameId",
                table: "LocalizationSets");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "LocalizationSets");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "LocalizationSets");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "LocalizationSets");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Books_LocalizationSets_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "LocalizationSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_LocalizationSets_DescriptionId",
                table: "Books",
                column: "DescriptionId",
                principalTable: "LocalizationSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_LocalizationSets_NameId",
                table: "Books",
                column: "NameId",
                principalTable: "LocalizationSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_LocalizationSets_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_LocalizationSets_DescriptionId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_LocalizationSets_NameId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_DescriptionId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_NameId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "LocalizationSets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "LocalizationSets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NameId",
                table: "LocalizationSets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocalizationSets_AuthorId",
                table: "LocalizationSets",
                column: "AuthorId",
                unique: true,
                filter: "[AuthorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LocalizationSets_DescriptionId",
                table: "LocalizationSets",
                column: "DescriptionId",
                unique: true,
                filter: "[DescriptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LocalizationSets_NameId",
                table: "LocalizationSets",
                column: "NameId",
                unique: true,
                filter: "[NameId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_LocalizationSets_Books_AuthorId",
                table: "LocalizationSets",
                column: "AuthorId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocalizationSets_Books_DescriptionId",
                table: "LocalizationSets",
                column: "DescriptionId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocalizationSets_Books_NameId",
                table: "LocalizationSets",
                column: "NameId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
