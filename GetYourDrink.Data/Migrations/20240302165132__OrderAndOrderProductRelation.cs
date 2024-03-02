using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetYourDrink.Data.Migrations
{
    /// <inheritdoc />
    public partial class _OrderAndOrderProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
