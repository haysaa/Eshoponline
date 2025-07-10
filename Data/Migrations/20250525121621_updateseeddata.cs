using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ESHOPONLINE.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Appetizer");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Entree");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "Side Dish");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CategoryName",
                value: "Dessert");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CategoryName",
                value: "Beverage");

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 1, "Beef" },
                    { 2, "Chicken" },
                    { 3, "Fish" },
                    { 4, "Tortilla" },
                    { 5, "Lettuce" },
                    { 6, "Tomato" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "ProductName", "Stock" },
                values: new object[] { 2, "A delicious beef taco", "https://via.placeholder.com/150", 2.50m, "Beef Taco", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "ProductName", "Stock" },
                values: new object[] { 2, "A delicious chicken taco", "https://via.placeholder.com/150", 1.99m, "Chicken Taco", 101 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Price", "ProductName", "Stock" },
                values: new object[] { "A delicious fish taco", "https://via.placeholder.com/150", 3.99m, "Fish Taco", 90 });

            migrationBuilder.InsertData(
                table: "ProductIngredient",
                columns: new[] { "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 2, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngredient",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "IngredientId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Fashion");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "Home & Kitchen");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CategoryName",
                value: "Beauty & Personal Care");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CategoryName",
                value: "Sports & Outdoor");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "ProductName", "Stock" },
                values: new object[] { 1, "2.4 GHz, 1600 DPI, USB alıcı dâhil", "/images/products/mouse.jpg", 299.90m, "Wireless Mouse", 150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "ProductName", "Stock" },
                values: new object[] { 1, "Bluetooth 5.3, 40 h pil ömrü", "/images/products/headphones.jpg", 1499.00m, "Noise-Cancelling Headphones", 85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Price", "ProductName", "Stock" },
                values: new object[] { "100 % pamuk, slim-fit, siyah", "/images/products/tshirt.jpg", 129.90m, "Men's Basic T-Shirt", 500 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageUrl", "Price", "ProductName", "Stock" },
                values: new object[,]
                {
                    { 4, 3, "Bulaşık makinesine uygun, beyaz", "/images/products/dinner-set.jpg", 749.50m, "12-Piece Ceramic Dinner Set", 60 },
                    { 5, 5, "Kaymaz, taşıma askılı, mor", "/images/products/yoga-mat.jpg", 239.00m, "Yoga Mat 8 mm", 200 }
                });
        }
    }
}
