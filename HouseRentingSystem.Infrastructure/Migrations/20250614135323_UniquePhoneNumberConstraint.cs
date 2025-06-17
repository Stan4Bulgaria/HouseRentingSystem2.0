using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem2._0.Infrastructure.Migrations
{
    public partial class UniquePhoneNumberConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Agents",
                comment: "House agent");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feda0778-d4ec-4eec-8d22-e58f11424a73", "AQAAAAEAACcQAAAAEF3W98qIX243UiiaHV7+0YMN941HuzbknRX7iTrGMHRhvQChZ4NJxbCvSl5YwdXkEg==", "c3237998-1f06-4099-a1c2-bd02db0c81b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9da5615-3a5e-447b-af90-53a18f719665", "AQAAAAEAACcQAAAAEG/gwoyqX+G58Rn0YR+XH1oryzdXYhfstrUKriMvgcAAVVz0u+gFxHv2uJlmE6DW3w==", "bf362c4b-8d21-4839-bbbc-9d5809c062fb" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.AlterTable(
                name: "Agents",
                oldComment: "House agent");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fff94c9-f9b7-4bba-80a8-526165ea28f2", "AQAAAAEAACcQAAAAEJOy3qHBv/2xleMKKT1gHTHTjn0t1TSAFGLDs8T8PtXyXvkFJ2KJmRQllJfbkWfzXg==", "e7c7a7ea-e841-47e5-b329-d43437c63849" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6125847d-821d-4e37-90ad-d3ec3539fa88", "AQAAAAEAACcQAAAAEJGWvPfN960LhGy0GFIAdY/FcPFVOChLeCGgHxUscz29k1iGgM8T/C4giVOuL/LWww==", "7160bbf3-5cf3-4504-95c7-92c7293f4f90" });
        }
    }
}
