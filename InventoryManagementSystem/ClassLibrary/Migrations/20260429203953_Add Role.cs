using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Class_Library.Migrations
{
    /// <inheritdoc />
    public partial class AddRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbCategory",
                columns: table => new
                {
                    catid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    catname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCategory", x => x.catid);
                });

            migrationBuilder.CreateTable(
                name: "tbCustomer",
                columns: table => new
                {
                    cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCustomer", x => x.cid);
                });

            migrationBuilder.CreateTable(
                name: "tbProduct",
                columns: table => new
                {
                    pid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    pqty = table.Column<int>(type: "int", nullable: false),
                    pprice = table.Column<int>(type: "int", nullable: false),
                    pdescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pcategory = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProduct", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "tbUser",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fullname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbUser", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "tbOrder",
                columns: table => new
                {
                    oid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    odate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pid = table.Column<int>(type: "int", nullable: false),
                    cid = table.Column<int>(type: "int", nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbOrder", x => x.oid);
                    table.ForeignKey(
                        name: "FK_tbOrder_tbCustomer_cid",
                        column: x => x.cid,
                        principalTable: "tbCustomer",
                        principalColumn: "cid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbOrder_tbProduct_pid",
                        column: x => x.pid,
                        principalTable: "tbProduct",
                        principalColumn: "pid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tbUser",
                columns: new[] { "username", "fullname", "password", "phone", "role" },
                values: new object[] { "admin", "Administrator", "admin123", "01000000000", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_tbOrder_cid",
                table: "tbOrder",
                column: "cid");

            migrationBuilder.CreateIndex(
                name: "IX_tbOrder_pid",
                table: "tbOrder",
                column: "pid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbCategory");

            migrationBuilder.DropTable(
                name: "tbOrder");

            migrationBuilder.DropTable(
                name: "tbUser");

            migrationBuilder.DropTable(
                name: "tbCustomer");

            migrationBuilder.DropTable(
                name: "tbProduct");
        }
    }
}
