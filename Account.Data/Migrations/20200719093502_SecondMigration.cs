using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Account.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "Customers",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenDate",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 19, 12, 35, 1, 541, DateTimeKind.Local).AddTicks(9695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 19, 12, 18, 25, 826, DateTimeKind.Local).AddTicks(196));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Customers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 19, 12, 18, 25, 826, DateTimeKind.Local).AddTicks(196),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 19, 12, 35, 1, 541, DateTimeKind.Local).AddTicks(9695));
        }
    }
}
