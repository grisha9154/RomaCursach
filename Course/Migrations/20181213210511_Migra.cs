using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Course.Migrations
{
    public partial class Migra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Spares",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Spares",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
