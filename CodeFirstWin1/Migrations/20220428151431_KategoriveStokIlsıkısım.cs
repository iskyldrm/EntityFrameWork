using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstWin1.Migrations
{
    public partial class KategoriveStokIlsıkısım : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateFate",
                table: "Stoklar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Stoklar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateFate",
                table: "Kategoriler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Kategoriler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
