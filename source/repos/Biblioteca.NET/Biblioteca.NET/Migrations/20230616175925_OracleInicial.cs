using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.NET.Migrations
{
    /// <inheritdoc />
    public partial class OracleInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    cdLivro = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    dsTitulo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dsAutor = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dtPublicacao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    nrPaginas = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    dsCategoria = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.cdLivro);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");
        }
    }
}
