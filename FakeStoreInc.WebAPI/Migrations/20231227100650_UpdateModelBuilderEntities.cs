using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeStoreInc.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelBuilderEntities : Migration
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

            migrationBuilder.DropIndex(
                name: "ix_order_details_color_id",
                table: "order_details");

            migrationBuilder.DropIndex(
                name: "ix_order_details_size_id",
                table: "order_details");

            migrationBuilder.AddColumn<Guid>(
                name: "category_id1",
                table: "products",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "product_id1",
                table: "product_size",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "product_id1",
                table: "product_color",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_products_category_id1",
                table: "products",
                column: "category_id1");

            migrationBuilder.CreateIndex(
                name: "ix_product_size_product_id1",
                table: "product_size",
                column: "product_id1");

            migrationBuilder.CreateIndex(
                name: "ix_product_color_product_id1",
                table: "product_color",
                column: "product_id1");

            migrationBuilder.AddForeignKey(
                name: "fk_product_color_products_product_id1",
                table: "product_color",
                column: "product_id1",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_product_size_products_product_id1",
                table: "product_size",
                column: "product_id1",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_products_categories_category_id1",
                table: "products",
                column: "category_id1",
                principalTable: "categories",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_product_color_products_product_id1",
                table: "product_color");

            migrationBuilder.DropForeignKey(
                name: "fk_product_size_products_product_id1",
                table: "product_size");

            migrationBuilder.DropForeignKey(
                name: "fk_products_categories_category_id1",
                table: "products");

            migrationBuilder.DropIndex(
                name: "ix_products_category_id1",
                table: "products");

            migrationBuilder.DropIndex(
                name: "ix_product_size_product_id1",
                table: "product_size");

            migrationBuilder.DropIndex(
                name: "ix_product_color_product_id1",
                table: "product_color");

            migrationBuilder.DropColumn(
                name: "category_id1",
                table: "products");

            migrationBuilder.DropColumn(
                name: "product_id1",
                table: "product_size");

            migrationBuilder.DropColumn(
                name: "product_id1",
                table: "product_color");

            migrationBuilder.CreateIndex(
                name: "ix_order_details_color_id",
                table: "order_details",
                column: "color_id");

            migrationBuilder.CreateIndex(
                name: "ix_order_details_size_id",
                table: "order_details",
                column: "size_id");

            migrationBuilder.AddForeignKey(
                name: "fk_order_details_product_color_color_id",
                table: "order_details",
                column: "color_id",
                principalTable: "product_color",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_order_details_product_size_size_id",
                table: "order_details",
                column: "size_id",
                principalTable: "product_size",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
