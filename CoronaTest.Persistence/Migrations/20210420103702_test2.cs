using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaTest.Persistence.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "aNksDsMbv5xQLgExzAzWKj0qOb7VQoumInsRdXekr+E=01ad922783c232ceccccbc4ca81509a7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "f82xsLcSIDNSCjaOdIpSPXq3c7pHNjQiSFbaNHhPurw=047dcd16bf167fd763f8fcf4ad40b00e");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
