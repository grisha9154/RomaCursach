using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Course.Migrations
{
    public partial class Last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeSpares",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSpares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spares",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameSpare = table.Column<string>(nullable: true),
                    Article = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true),
                    TypeSpareId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spares_TypeSpares_TypeSpareId",
                        column: x => x.TypeSpareId,
                        principalTable: "TypeSpares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spares_TypeSpareId",
                table: "Spares",
                column: "TypeSpareId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spares");

            migrationBuilder.DropTable(
                name: "TypeSpares");
        }
    }
}
