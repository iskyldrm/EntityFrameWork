using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstWin1.Migrations.Postgre
{
    public partial class KategoriveStokIlsıkısı : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stoklar_Kategoriler_KategoriId",
                table: "Stoklar");

            migrationBuilder.DropIndex(
                name: "IX_Stoklar_KategoriId",
                table: "Stoklar");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "Stoklar");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateFate",
                table: "Stoklar",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Stoklar",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateFate",
                table: "Kategoriler",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Kategoriler",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "KategoriStok",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "integer", nullable: false),
                    StoklarId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriStok", x => new { x.KategoriId, x.StoklarId });
                    table.ForeignKey(
                        name: "FK_KategoriStok_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriStok_Stoklar_StoklarId",
                        column: x => x.StoklarId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KategoriStok_StoklarId",
                table: "KategoriStok",
                column: "StoklarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KategoriStok");

            migrationBuilder.DropColumn(
                name: "CreateFate",
                table: "Stoklar");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Stoklar");

            migrationBuilder.DropColumn(
                name: "CreateFate",
                table: "Kategoriler");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Kategoriler");

            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "Stoklar",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_KategoriId",
                table: "Stoklar",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stoklar_Kategoriler_KategoriId",
                table: "Stoklar",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
