using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeStoreInc.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemoveProductSizeAndColorFromDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_order_details_product_color_color_id",
                table: "order_details");

            migrationBuilder.DropForeignKey(
                name: "fk_order_details_product_size_size_id",
                table: "order_details");

            migrationBuilder.DropTable(
                name: "product_color");

            migrationBuilder.DropTable(
                name: "product_size");

            migrationBuilder.DropIndex(
                name: "ix_order_details_color_id",
                table: "order_details");

            migrationBuilder.DropIndex(
                name: "ix_order_details_size_id",
                table: "order_details");

            migrationBuilder.DropColumn(
                name: "color_id",
                table: "order_details");

            migrationBuilder.DropColumn(
                name: "size_id",
                table: "order_details");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "color_id",
                table: "order_details",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "size_id",
                table: "order_details",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "product_color",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    product_id = table.Column<Guid>(type: "uuid", nullable: false),
                    product_id1 = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_product_color", x => x.id);
                    table.ForeignKey(
                        name: "fk_product_color_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_product_color_products_product_id1",
                        column: x => x.product_id1,
                        principalTable: "products",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "product_size",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    product_id = table.Column<Guid>(type: "uuid", nullable: false),
                    product_id1 = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_product_size", x => x.id);
                    table.ForeignKey(
                        name: "fk_product_size_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_product_size_products_product_id1",
                        column: x => x.product_id1,
                        principalTable: "products",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_order_details_color_id",
                table: "order_details",
                column: "color_id");

            migrationBuilder.CreateIndex(
                name: "ix_order_details_size_id",
                table: "order_details",
                column: "size_id");

            migrationBuilder.CreateIndex(
                name: "ix_product_color_product_id",
                table: "product_color",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_product_color_product_id1",
                table: "product_color",
                column: "product_id1");

            migrationBuilder.CreateIndex(
                name: "ix_product_size_product_id",
                table: "product_size",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_product_size_product_id1",
                table: "product_size",
                column: "product_id1");

            migrationBuilder.AddForeignKey(
                name: "fk_order_details_product_color_color_id",
                table: "order_details",
                column: "color_id",
                principalTable: "product_color",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_order_details_product_size_size_id",
                table: "order_details",
                column: "size_id",
                principalTable: "product_size",
                principalColumn: "id");
        }
    }
}
