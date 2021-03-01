using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreContentLocalization.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocalizationSets_Books_FK_Books_LocalizationSets_AuthorId",
                table: "LocalizationSets");

            migrationBuilder.DropForeignKey(
                name: "FK_LocalizationSets_Books_FK_Books_LocalizationSets_DescriptionId",
                table: "LocalizationSets");

            migrationBuilder.DropForeignKey(
                name: "FK_LocalizationSets_Books_FK_Books_LocalizationSets_NameId",
                table: "LocalizationSets");

            migrationBuilder.DropIndex(
                name: "IX_LocalizationSets_FK_Books_LocalizationSets_AuthorId",
                table: "LocalizationSets");

            migrationBuilder.DropIndex(
                name: "IX_LocalizationSets_FK_Books_LocalizationSets_DescriptionId",
                table: "LocalizationSets");

            migrationBuilder.DropIndex(
                name: "IX_LocalizationSets_FK_Books_LocalizationSets_NameId",
                table: "LocalizationSets");

            migrationBuilder.DropColumn(
                name: "FK_Books_LocalizationSets_AuthorId",
                table: "LocalizationSets");

            migrationBuilder.DropColumn(
                name: "FK_Books_LocalizationSets_DescriptionId",
                table: "LocalizationSets");

            migrationBuilder.DropColumn(
                name: "FK_Books_LocalizationSets_NameId",
                table: "LocalizationSets");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "LocalizationSets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "LocalizationSets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NameId",
                table: "LocalizationSets",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "FK_Books_LocalizationSets_AuthorId",
                table: "LocalizationSets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_Books_LocalizationSets_DescriptionId",
                table: "LocalizationSets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_Books_LocalizationSets_NameId",
                table: "LocalizationSets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocalizationSets_FK_Books_LocalizationSets_AuthorId",
                table: "LocalizationSets",
                column: "FK_Books_LocalizationSets_AuthorId",
                unique: true,
                filter: "[FK_Books_LocalizationSets_AuthorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LocalizationSets_FK_Books_LocalizationSets_DescriptionId",
                table: "LocalizationSets",
                column: "FK_Books_LocalizationSets_DescriptionId",
                unique: true,
                filter: "[FK_Books_LocalizationSets_DescriptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LocalizationSets_FK_Books_LocalizationSets_NameId",
                table: "LocalizationSets",
                column: "FK_Books_LocalizationSets_NameId",
                unique: true,
                filter: "[FK_Books_LocalizationSets_NameId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_LocalizationSets_Books_FK_Books_LocalizationSets_AuthorId",
                table: "LocalizationSets",
                column: "FK_Books_LocalizationSets_AuthorId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocalizationSets_Books_FK_Books_LocalizationSets_DescriptionId",
                table: "LocalizationSets",
                column: "FK_Books_LocalizationSets_DescriptionId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocalizationSets_Books_FK_Books_LocalizationSets_NameId",
                table: "LocalizationSets",
                column: "FK_Books_LocalizationSets_NameId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
