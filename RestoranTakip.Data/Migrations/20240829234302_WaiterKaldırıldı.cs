using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoranTakip.Data.Migrations
{
    /// <inheritdoc />
    public partial class WaiterKaldırıldı : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_AppUsers_AppUserId",
                table: "Tables");

            migrationBuilder.DropTable(
                name: "TableWaiter");

            migrationBuilder.DropTable(
                name: "Waiters");

            migrationBuilder.DropIndex(
                name: "IX_Tables_AppUserId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Tables");

            migrationBuilder.CreateTable(
                name: "AppUserTable",
                columns: table => new
                {
                    AppUsersId = table.Column<int>(type: "int", nullable: false),
                    TablesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTable", x => new { x.AppUsersId, x.TablesId });
                    table.ForeignKey(
                        name: "FK_AppUserTable_AppUsers_AppUsersId",
                        column: x => x.AppUsersId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserTable_Tables_TablesId",
                        column: x => x.TablesId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserTable_TablesId",
                table: "AppUserTable",
                column: "TablesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserTable");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Tables",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Waiters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waiters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableWaiter",
                columns: table => new
                {
                    TablesId = table.Column<int>(type: "int", nullable: false),
                    WaitersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableWaiter", x => new { x.TablesId, x.WaitersId });
                    table.ForeignKey(
                        name: "FK_TableWaiter_Tables_TablesId",
                        column: x => x.TablesId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TableWaiter_Waiters_WaitersId",
                        column: x => x.WaitersId,
                        principalTable: "Waiters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tables_AppUserId",
                table: "Tables",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TableWaiter_WaitersId",
                table: "TableWaiter",
                column: "WaitersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_AppUsers_AppUserId",
                table: "Tables",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id");
        }
    }
}
