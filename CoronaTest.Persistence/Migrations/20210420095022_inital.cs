using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaTest.Persistence.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "DEA8Q1fsW+rtSAGuMaovxNlcVZNQkUzK2uh/iCvljYc=5c9a6226b37deeccef54a701091b40ec");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "mvrsO9jUpgdNkHYeaSxcGs2MOxUWJU/vO6vE2n+VojU=4dd666990578e385d2d36da85abfaec0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "7Vjuh9W2boYzDHCJjLzbZJwa3gD7WnMvvCkAibffOKQ=b484911641347bcc8ab104e49205b17b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "dZ+t9U4ET9ocsW5uzug54Xcfo4s4SLjhVBKHtPidIL4=63994ca3c221dca7a080232be08157b1");
        }
    }
}
