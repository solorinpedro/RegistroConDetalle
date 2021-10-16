using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroConDetalle.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    PermisoID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.PermisoID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoiID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    EsActivo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoiID);
                });

            migrationBuilder.CreateTable(
                name: "RolesDetalle",
                columns: table => new
                {
                    RolesDetalleID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoiID = table.Column<int>(type: "INTEGER", nullable: false),
                    PermisoID = table.Column<int>(type: "INTEGER", nullable: false),
                    EsAsignado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesDetalle", x => x.RolesDetalleID);
                    table.ForeignKey(
                        name: "FK_RolesDetalle_Permisos_PermisoID",
                        column: x => x.PermisoID,
                        principalTable: "Permisos",
                        principalColumn: "PermisoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolesDetalle_Roles_RoiID",
                        column: x => x.RoiID,
                        principalTable: "Roles",
                        principalColumn: "RoiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "PermisoID", "Descripcion", "Nombre" },
                values: new object[] { 1, "Area Ciberseguridad", "Pedro Solorin" });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "PermisoID", "Descripcion", "Nombre" },
                values: new object[] { 2, "Administrador", "Randis Tejada" });

            migrationBuilder.CreateIndex(
                name: "IX_RolesDetalle_PermisoID",
                table: "RolesDetalle",
                column: "PermisoID");

            migrationBuilder.CreateIndex(
                name: "IX_RolesDetalle_RoiID",
                table: "RolesDetalle",
                column: "RoiID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolesDetalle");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
