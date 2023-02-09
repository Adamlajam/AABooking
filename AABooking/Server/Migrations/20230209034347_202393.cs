using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AABooking.Server.Migrations
{
    public partial class _202393 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "4f2e358a-3473-48c8-b0a1-cd076d03a678");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "8043775b-2411-4a0b-8105-8e2354b3e00f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3e6d124-01e1-4f20-afcb-36e3baf454e3", "AQAAAAEAACcQAAAAEHNtlCXG5kTNO3nMIyMnM1DFEk3NxQRsxd2SWCSMqmCIJ2hXUsfepUBt+nj+sNKmVw==", "8fe71dcc-5794-4922-a462-ea2e2b0ab610" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 9, 11, 43, 47, 299, DateTimeKind.Local).AddTicks(243), new DateTime(2023, 2, 9, 11, 43, 47, 298, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 9, 11, 43, 47, 299, DateTimeKind.Local).AddTicks(1523), new DateTime(2023, 2, 9, 11, 43, 47, 299, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservationDate", "ReservationTime" },
                values: new object[] { new DateTime(2023, 2, 9, 11, 43, 47, 299, DateTimeKind.Local).AddTicks(1526), new DateTime(2023, 2, 9, 11, 43, 47, 299, DateTimeKind.Local).AddTicks(1525) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
