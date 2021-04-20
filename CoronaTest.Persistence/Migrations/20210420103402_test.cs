using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaTest.Persistence.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "E7KEFl/IaxdtXkT1VGntBWVqOJmFONzEq1e/xjvblkI=fa51a78fc3b76917b02cdab8512ab8d2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "z9nbkPwZ2SKQjyGVZ9rwHM40QfV4ogxoDgJpgQiofP4=6eccea74ba8610bcff938af918d2fb38");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
