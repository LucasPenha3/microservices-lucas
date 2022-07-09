using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProdDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "name", "price", "image_url" },
                values: new object[,]
                {
                    { 3, "Categoria produto 3", "Descrição do produto 3", "Produto 3", 30m, "http://teste.com" },
                    { 4, "Categoria produto 4", "Descrição do produto 4", "Produto 4", 40m, "http://teste.com" },
                    { 5, "Categoria produto 5", "Descrição do produto 5", "Produto 5", 50m, "http://teste.com" },
                    { 6, "Categoria produto 6", "Descrição do produto 6", "Produto 6", 60m, "http://teste.com" },
                    { 7, "Categoria produto 7", "Descrição do produto 7", "Produto 7", 70m, "http://teste.com" },
                    { 8, "Categoria produto 8", "Descrição do produto 8", "Produto 8", 80m, "http://teste.com" },
                    { 9, "Categoria produto 9", "Descrição do produto 9", "Produto 9", 90m, "http://teste.com" },
                    { 10, "Categoria produto 10", "Descrição do produto 10", "Produto 10", 100m, "http://teste.com" },
                    { 11, "Categoria produto 11", "Descrição do produto 11", "Produto 11", 110m, "http://teste.com" },
                    { 12, "Categoria produto 12", "Descrição do produto 12", "Produto 12", 120m, "http://teste.com" },
                    { 13, "Categoria produto 13", "Descrição do produto 13", "Produto 13", 130m, "http://teste.com" },
                    { 14, "Categoria produto 14", "Descrição do produto 14", "Produto 14", 140m, "http://teste.com" },
                    { 15, "Categoria produto 15", "Descrição do produto 15", "Produto 15", 150m, "http://teste.com" },
                    { 16, "Categoria produto 16", "Descrição do produto 16", "Produto 16", 160m, "http://teste.com" },
                    { 17, "Categoria produto 17", "Descrição do produto 17", "Produto 17", 170m, "http://teste.com" },
                    { 18, "Categoria produto 18", "Descrição do produto 18", "Produto 18", 180m, "http://teste.com" },
                    { 19, "Categoria produto 19", "Descrição do produto 19", "Produto 19", 190m, "http://teste.com" },
                    { 20, "Categoria produto 20", "Descrição do produto 20", "Produto 20", 200m, "http://teste.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 20);
        }
    }
}
