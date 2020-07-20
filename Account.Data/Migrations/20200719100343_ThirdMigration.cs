using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Account.Data.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Customers",
                nullable: false,
                defaultValue: new Guid("1e09ce75-e7a4-4bd8-9509-1e12d99bb64b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenDate",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 19, 13, 3, 43, 432, DateTimeKind.Local).AddTicks(6053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 19, 12, 35, 1, 541, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.AlterColumn<Guid>(
                name: "AccountId",
                table: "Accounts",
                nullable: false,
                defaultValue: new Guid("608d62d2-a2e1-4890-9275-8bbae91bee15"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("1e09ce75-e7a4-4bd8-9509-1e12d99bb64b"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 19, 12, 35, 1, 541, DateTimeKind.Local).AddTicks(9695),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 19, 13, 3, 43, 432, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.AlterColumn<Guid>(
                name: "AccountId",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("608d62d2-a2e1-4890-9275-8bbae91bee15"));
        }
    }
}
