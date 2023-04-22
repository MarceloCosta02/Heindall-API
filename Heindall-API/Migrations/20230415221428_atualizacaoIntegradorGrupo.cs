using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Heindall_API.Migrations
{
    public partial class atualizacaoIntegradorGrupo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Integradores_Grupos_GrupoId",
                table: "Integradores");

            migrationBuilder.AlterColumn<string>(
                name: "IntegradorEndpoint",
                table: "Integradores",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "GrupoId",
                table: "Integradores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Integradores_Grupos_GrupoId",
                table: "Integradores",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Integradores_Grupos_GrupoId",
                table: "Integradores");

            migrationBuilder.AlterColumn<int>(
                name: "IntegradorEndpoint",
                table: "Integradores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "GrupoId",
                table: "Integradores",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Integradores_Grupos_GrupoId",
                table: "Integradores",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id");
        }
    }
}
