using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE3.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Teachers",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.InsertData(
                table: "Pupils",
                columns: new[] { "Id", "Birthdate", "ClassRoomId", "CurrentLevel", "FirstName", "LastName", "TeacherId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Jonas", "Wouters", null },
                    { 2L, new DateTime(2010, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Henk", "Verweer", null },
                    { 3L, new DateTime(2009, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Emma", "Verdonck", null },
                    { 4L, new DateTime(2010, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Chloe", "Pashalis", null },
                    { 5L, new DateTime(2010, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Amelia", "Armstrong", null },
                    { 6L, new DateTime(2009, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Nick", "Vermeersch", null },
                    { 7L, new DateTime(2010, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "John", "Crombez", null },
                    { 8L, new DateTime(2010, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Erik", "Braet", null },
                    { 9L, new DateTime(2010, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Lily", "Peeters", null },
                    { 10L, new DateTime(2010, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Pieter-Paul", "Pruim", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName", "Login", "Password" },
                values: new object[,]
                {
                    { 1L, "Dirk", "Vandenbroucke", "dvandenbroucke", "teacher" },
                    { 2L, "Evan", "Dierickx", "edierickx", "teacher" },
                    { 3L, "Sam", "Verkeyen", "sverkeyen", "teacher" },
                    { 4L, "Erika", "Berends", "eberends", "teacher" },
                    { 5L, "Sarah", "Cramers", "scramers", "teacher" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.AlterColumn<long>(
                name: "Password",
                table: "Teachers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
