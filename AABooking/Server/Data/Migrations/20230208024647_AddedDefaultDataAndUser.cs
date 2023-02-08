using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AABooking.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "95f92843-da82-4322-82d5-4dd96f6fd855", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "f047b95f-3f7a-4c02-97bd-58237203de8a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "874ea55d-3943-4b2f-9f4e-c7adde0ea1e4", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEEN6NQVsCDD3W3Vq0tq1fKqq79T4uqa5NLqC8v0iBb7AcvwiVDXtN4Hpp6F0FiwWOA==", null, false, "6c33c40c-503c-4273-a784-f05934c85c03", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CusId", "Address", "Contact", "ResId", "ReservationId",  },
                values: new object[,]
                {
                    { 1, "111a", "91145295", 0, 0 },
                    { 2, "111a", "90461363", 0, 0 },
                    { 3, "111a", "97346471", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CusId", "ResId", "ReservationDate", "ReservationTime",  "TableId" },
                values: new object[,]
                {
                    { 1, 0, 0, new DateTime(2023, 2, 8, 10, 46, 47, 342, DateTimeKind.Local).AddTicks(5226), new DateTime(2023, 2, 8, 10, 46, 47, 341, DateTimeKind.Local).AddTicks(5534), 0 },
                    { 2, 0, 0, new DateTime(2023, 2, 8, 10, 46, 47, 342, DateTimeKind.Local).AddTicks(5628), new DateTime(2023, 2, 8, 10, 46, 47, 342, DateTimeKind.Local).AddTicks(5621),  0 },
                    { 3, 0, 0, new DateTime(2023, 2, 8, 10, 46, 47, 342, DateTimeKind.Local).AddTicks(5631), new DateTime(2023, 2, 8, 10, 46, 47, 342, DateTimeKind.Local).AddTicks(5630), 0 }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "Address", "Contact", "ResId",  "Role" },
                values: new object[,]
                {
                    { 1, "111a", "11111111", 0, null },
                    { 2, "222a", "22222222", 0, null },
                    { 3, "333a", "33333333", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "ResId", "ReservationId", },
                values: new object[,]
                {
                    { 1, 0, 0 },
                    { 2, 0, 0 },
                    { 3, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
