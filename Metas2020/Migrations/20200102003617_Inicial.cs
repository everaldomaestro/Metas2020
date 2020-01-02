using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Metas2020.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    areaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.areaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Meta",
                columns: table => new
                {
                    metaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_inicio = table.Column<DateTime>(nullable: false),
                    usuarioId = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(nullable: false),
                    areaId = table.Column<int>(nullable: false),
                    usa_recurso_financeiro = table.Column<bool>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meta", x => x.metaId);
                    table.ForeignKey(
                        name: "FK_Meta_Area_areaId",
                        column: x => x.areaId,
                        principalTable: "Area",
                        principalColumn: "areaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meta_Usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estrategia",
                columns: table => new
                {
                    estrategiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    metaId = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(nullable: false),
                    data_inicio = table.Column<DateTime>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estrategia", x => x.estrategiaId);
                    table.ForeignKey(
                        name: "FK_Estrategia_Meta_metaId",
                        column: x => x.metaId,
                        principalTable: "Meta",
                        principalColumn: "metaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estrategia_metaId",
                table: "Estrategia",
                column: "metaId");

            migrationBuilder.CreateIndex(
                name: "IX_Meta_areaId",
                table: "Meta",
                column: "areaId");

            migrationBuilder.CreateIndex(
                name: "IX_Meta_usuarioId",
                table: "Meta",
                column: "usuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estrategia");

            migrationBuilder.DropTable(
                name: "Meta");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
