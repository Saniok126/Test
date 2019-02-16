using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "Items", columns: new[] { "Id", "Name" },
            values: new object[] { "25F1F0CB-91F5-4835-BFC3-C6EE2116D8A3", "Пицца" });
            migrationBuilder.InsertData(table: "Items", columns: new[] { "Id", "Name" },
              values: new object[] { "25F1F0CB-91F5-4835-BFC3-C6EE2116D8A4", "Суши" });
            migrationBuilder.InsertData(table: "Items", columns: new[] { "Id", "Name" },
              values: new object[] { "25F1F0CB-91F5-4835-BFC3-C6EE2116D8A5", "Пиво" });
            migrationBuilder.InsertData(table: "Items", columns: new[] { "Id", "Name" },
              values: new object[] { "25F1F0CB-91F5-4835-BFC3-C6EE2116D8A6", "Креветки" });

            migrationBuilder.InsertData(table: "Clients", columns: new[] { "Id", "FirstName", "LastName" },
              values: new object[] { "25F1F0CB-91F5-4835-BFC3-C6EE2116D8A1", "Саша", "Черненко" });
            migrationBuilder.InsertData(table: "Clients", columns: new[] { "Id", "FirstName", "LastName" },
             values: new object[] { "25F1F0CB-91F5-4835-BFC3-C6EE2116D8A2", "Саша", "Ткаченко" });
            migrationBuilder.InsertData(table: "Clients", columns: new[] { "Id", "FirstName", "LastName" },
             values: new object[] { "25F1F0CB-91F5-4835-BFC3-C6EE2116D8A7", "Вася", "Петичкин" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
