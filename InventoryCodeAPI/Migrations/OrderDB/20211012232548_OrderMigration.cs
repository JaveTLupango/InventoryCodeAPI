using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryCodeAPI.Migrations.OrderDB
{
    public partial class OrderMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    totalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalProductPurchase = table.Column<int>(type: "int", nullable: false),
                    UDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");
        }
    }
}
