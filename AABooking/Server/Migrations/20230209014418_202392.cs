using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AABooking.Server.Migrations
{
    public partial class _202392 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "98726f6f-fbec-4c31-b5c9-022aad064974");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "5fb2e5c6-956a-4af1-8e5f-b2113b2dd361");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faad4266-ab48-4c90-8f1b-6fb3ec1a00c1", "AQAAAAEAACcQAAAAEF1+lIrhCiDP0ua8wh6SSttk34fCBSIeJG/A49mOF3E1SpPjnsNzcNPJqKHa7miyBg==", "6b6fbcb3-03c0-403f-878b-3026e5b1fb07" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 9, 9, 44, 17, 472, DateTimeKind.Local).AddTicks(5254), new DateTime(2023, 2, 9, 9, 44, 17, 471, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 9, 9, 44, 17, 472, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 2, 9, 9, 44, 17, 472, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 9, 9, 44, 17, 472, DateTimeKind.Local).AddTicks(6745), new DateTime(2023, 2, 9, 9, 44, 17, 472, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ResId",
                keyValue: 1,
                column: "ResName",
                value: "Italian Restaurant");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ResId",
                keyValue: 2,
                columns: new[] { "Contact", "ResName" },
                values: new object[] { "97346471", "Mexican Restaurant" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ResId",
                keyValue: 3,
                columns: new[] { "Contact", "ResName" },
                values: new object[] { "90461363", "Chinese Restaurant" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "412f11d7-fc20-43e9-9c87-df0592acba5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "5e844c6b-b78e-4d42-b482-f5dac4f120df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53762d38-1742-45fb-b43a-7b3ab99a51ed", "AQAAAAEAACcQAAAAEIgJQbwAkFv+WanDOdBxakQgM9xSrmc8GZRDa7S/EbF+fwFhS8uBiMnGTT86dcd09w==", "c4177264-2b21-4fc0-b106-d5ecbfc6576d" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 8, 19, 5, 45, 724, DateTimeKind.Local).AddTicks(7673), new DateTime(2023, 2, 8, 19, 5, 45, 723, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 8, 19, 5, 45, 724, DateTimeKind.Local).AddTicks(9591), new DateTime(2023, 2, 8, 19, 5, 45, 724, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 8, 19, 5, 45, 724, DateTimeKind.Local).AddTicks(9596), new DateTime(2023, 2, 8, 19, 5, 45, 724, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ResId",
                keyValue: 1,
                column: "ResName",
                value: "Italian Restaurant");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ResId",
                keyValue: 2,
                columns: new[] { "Contact", "ResName" },
                values: new object[] { "91144444", "Mexican Restaurant" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ResId",
                keyValue: 3,
                columns: new[] { "Contact", "ResName" },
                values: new object[] { "99999999", "Chinese Restaurant" });
        }
    }
}
