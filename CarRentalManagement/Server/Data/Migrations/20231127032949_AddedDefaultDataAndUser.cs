using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a4078807-7d8a-4754-9151-65d06e104ecb", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEA6X4FJr343Z2WuCn0GxPWm4N1hxMzk81KK76FXkMjiQIah6ChiTgfrC6L3IS7Gvg==", null, false, "9214dc9b-3e68-43d8-8b50-cb7b9d91e6b1", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(398), new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(413), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(420), new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(421), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1025), new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1028), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1032), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1380), new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1382), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1385), new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1386), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1388), new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1389), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1391), new DateTime(2023, 11, 27, 11, 29, 48, 868, DateTimeKind.Local).AddTicks(1392), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
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
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

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
