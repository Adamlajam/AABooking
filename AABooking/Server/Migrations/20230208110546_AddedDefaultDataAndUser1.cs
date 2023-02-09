using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AABooking.Server.Migrations
{
    public partial class AddedDefaultDataAndUser1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "0121410e-83f6-4faf-820c-34b7395957c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "c85e04fb-d98a-4431-b820-141752e225ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "008814e0-28d2-4833-ad00-f6723d236220", "AQAAAAEAACcQAAAAEITnnnSg0DImo0oZ6SXpCJuZp+ygvX0+jMxm74k2mDDWZb6tKTqNj+1T+h6h0CksHA==", "79022c90-e49e-4531-b007-76fb19c5c290" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 8, 18, 55, 4, 342, DateTimeKind.Local).AddTicks(9039), new DateTime(2023, 2, 8, 18, 55, 4, 341, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 8, 18, 55, 4, 343, DateTimeKind.Local).AddTicks(311), new DateTime(2023, 2, 8, 18, 55, 4, 343, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 8, 18, 55, 4, 343, DateTimeKind.Local).AddTicks(315), new DateTime(2023, 2, 8, 18, 55, 4, 343, DateTimeKind.Local).AddTicks(313) });
        }
    }
}
