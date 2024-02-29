using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coordinator.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("658ad345-bcb2-427c-973e-71e5a7221227"), "Stock.API" },
                    { new Guid("c5f64548-de86-40ff-9826-2707219ae313"), "Order.API" },
                    { new Guid("d020fbf7-8060-48a7-9181-b3598ab71fbe"), "Payment.API" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("658ad345-bcb2-427c-973e-71e5a7221227"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("c5f64548-de86-40ff-9826-2707219ae313"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("d020fbf7-8060-48a7-9181-b3598ab71fbe"));
        }
    }
}
