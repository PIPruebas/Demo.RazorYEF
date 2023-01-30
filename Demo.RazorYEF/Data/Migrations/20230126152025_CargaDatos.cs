using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.RazorYEF.Data.Migrations
{
    public partial class CargaDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Descripcion", "Nombre", "UrlImagen" },
                values: new object[,]
                {
                    { 1, null, "Frescos", null },
                    { 2, null, "Despensa", null },
                    { 3, null, "Congelados", null },
                    { 4, null, "Bebidas", null }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "CategoriaId", "Descripcion", "Nombre", "UrlImagen" },
                values: new object[,]
                {
                    { 1, 1, "Calibre: 3 PIEZAS", "Maíz dulce cocido al vacío 400 gr", "/images/10477990608926.jpg" },
                    { 2, 1, "Malla 2 Kg", "Cebolla malla 2 Kg", "/images/8847033073694.png" },
                    { 3, 1, "Salchichas con queso", "OSCAR MAYER salchichas con queso envase 200 gr", "/images/10971771764766.jpg" },
                    { 4, 1, "Naranja 2Kg", "Naranja premium bolsa 2 Kg", "/images/11272783953950.jpg" },
                    { 5, 1, "Tomate rosa", "Tomate rosa de la reina unidad (peso aprox. 900 gr)", "/images/10937809993758.jpg" },
                    { 6, 1, "Melón", "Melón selección unidad (3.5 Kg aprox.)", "/images/producto17p.jpg" },
                    { 7, 2, "Aceite girasol", "KOIPE Sol aceite girasol botella 1 lt", "/images/11160116756510.jpg" },
                    { 8, 2, "Leche desnatada", "LAUKI leche desnatada envase 1 lt", "/images/11238530220062.jpg" },
                    { 9, 2, "Cereales", "KELLOGGS cereales corn flakes caja 500 gr", "/images/11265824653342.jpg" },
                    { 10, 2, "FINI golosinas", "FINI golosinas jelly cola bolsa 100 gr", "/images/10905632178206.jpg" },
                    { 11, 3, "Trenza", "RAPUN trenza de Huesca caja 450 gr", "/images/10465404551198.jpg" },
                    { 12, 4, null, "Agua 50cl", "/images/producto1p.jpg" },
                    { 13, 4, null, "Kas Naranja", "/images/producto2p.jpg" },
                    { 14, 4, null, "Kas Limón", "/images/producto3p.jpg" },
                    { 15, 4, null, "Pepsi", "/images/producto4p.jpg" },
                    { 16, 4, null, "Pepsi Light", "/images/producto5p.jpg" },
                    { 17, 4, null, "Pepsi Max", "/images/producto6p.jpg" },
                    { 18, 4, null, "Seven Up", "/images/producto9p.jpg" },
                    { 110, 3, "Pizza", "DR OETKER ristorante pizza spinaci caja 390 gr", "/images/11106487664670.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
