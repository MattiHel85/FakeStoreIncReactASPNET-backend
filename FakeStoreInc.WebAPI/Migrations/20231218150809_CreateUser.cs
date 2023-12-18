using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeStoreInc.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:role", "admin,customer");

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    categoryname = table.Column<string>(name: "category_name", type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    createddate = table.Column<DateTime>(name: "created_date", type: "timestamp with time zone", nullable: false),
                    updateddate = table.Column<DateTime>(name: "updated_date", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "order_items",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    orderitemid = table.Column<int>(name: "order_item_id", type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    paymentmethod = table.Column<decimal>(name: "payment_method", type: "numeric", nullable: false),
                    orderid = table.Column<int>(name: "order_id", type: "integer", nullable: false),
                    productid = table.Column<int>(name: "product_id", type: "integer", nullable: false),
                    createddate = table.Column<DateTime>(name: "created_date", type: "timestamp with time zone", nullable: false),
                    updateddate = table.Column<DateTime>(name: "updated_date", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_order_items", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    orderdate = table.Column<string>(name: "order_date", type: "text", nullable: true),
                    orderstatus = table.Column<int>(name: "order_status", type: "integer", nullable: false),
                    paymentmethod = table.Column<string>(name: "payment_method", type: "text", nullable: true),
                    userid = table.Column<int>(name: "user_id", type: "integer", nullable: false),
                    createddate = table.Column<DateTime>(name: "created_date", type: "timestamp with time zone", nullable: false),
                    updateddate = table.Column<DateTime>(name: "updated_date", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    productname = table.Column<string>(name: "product_name", type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    image = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<string>(type: "text", nullable: true),
                    stockquantity = table.Column<int>(name: "stock_quantity", type: "integer", nullable: false),
                    categoryid = table.Column<int>(name: "category_id", type: "integer", nullable: false),
                    createddate = table.Column<DateTime>(name: "created_date", type: "timestamp with time zone", nullable: false),
                    updateddate = table.Column<DateTime>(name: "updated_date", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    role = table.Column<int>(type: "integer", nullable: false),
                    firstname = table.Column<string>(name: "first_name", type: "text", nullable: true),
                    lastname = table.Column<string>(name: "last_name", type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    password = table.Column<string>(type: "text", nullable: true),
                    phonenumber = table.Column<string>(name: "phone_number", type: "text", nullable: true),
                    salt = table.Column<byte[]>(type: "bytea", nullable: true),
                    createddate = table.Column<DateTime>(name: "created_date", type: "timestamp with time zone", nullable: false),
                    updateddate = table.Column<DateTime>(name: "updated_date", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    housenumber = table.Column<int>(name: "house_number", type: "integer", nullable: false),
                    street = table.Column<string>(type: "text", nullable: true),
                    postcode = table.Column<string>(name: "post_code", type: "text", nullable: true),
                    userid = table.Column<Guid>(name: "user_id", type: "uuid", nullable: true),
                    createddate = table.Column<DateTime>(name: "created_date", type: "timestamp with time zone", nullable: false),
                    updateddate = table.Column<DateTime>(name: "updated_date", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_addresses", x => x.id);
                    table.ForeignKey(
                        name: "fk_addresses_users_user_id",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_addresses_user_id",
                table: "addresses",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "order_items");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
