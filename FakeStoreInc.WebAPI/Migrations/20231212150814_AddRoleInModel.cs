using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeStoreInc.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleInModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:role", "admin,customer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:Enum:role", "admin,customer");
        }
    }
}
