using System;
using FakeStoreInc.Core.src.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeStoreInc.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSuperAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_date", "email", "first_name", "last_name", "password", "phone_number", "role", "salt", "updated_date" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000666"), new DateTime(2023, 12, 27, 15, 11, 21, 578, DateTimeKind.Utc).AddTicks(1985), "matt.rc.simpson@gmail.com", "Super", "Admin", "System.Byte[]", null, Role.Admin, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000666"));
        }
    }
}
