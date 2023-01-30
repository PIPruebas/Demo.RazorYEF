using Demo.RazorYEF.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Demo.RazorYEF.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                {
                    Id = 1,
                    Nombre = "Frescos"
                },
                new Categoria
                {
                    Id = 2,
                    Nombre = "Despensa"
                },
                new Categoria
                {
                    Id = 3,
                    Nombre = "Congelados"
                },
            new Categoria
            {
                Id = 4,
                Nombre = "Bebidas"
            });

            modelBuilder.Entity<Producto>().HasData(CrearProductosDummy());
        }

        private static List<Producto> CrearProductosDummy()
        {
            List<Producto> resultado = new List<Producto>();

            resultado.Add(new Producto()
            {
                Id = 1,
                CategoriaId = 1,
                Nombre = "Maíz dulce cocido al vacío 400 gr",
                UrlImagen = "/images/10477990608926.jpg",
                Descripcion = "Calibre: 3 PIEZAS"
            });

            resultado.Add(new Producto()
            {
                Id = 2,
                CategoriaId = 1,
                Nombre = "Cebolla malla 2 Kg",
                UrlImagen = "/images/8847033073694.png",
                Descripcion = "Malla 2 Kg"
            });

            resultado.Add(new Producto()
            {
                Id = 3,
                CategoriaId = 1,
                Nombre = "OSCAR MAYER salchichas con queso envase 200 gr",
                UrlImagen = "/images/10971771764766.jpg",
                Descripcion = "Salchichas con queso"
            });

            resultado.Add(new Producto()
            {
                Id = 4,
                CategoriaId = 1,
                Nombre = "Naranja premium bolsa 2 Kg",
                UrlImagen = "/images/11272783953950.jpg",
                Descripcion = "Naranja 2Kg"
            });

            resultado.Add(new Producto()
            {
                Id = 5,
                CategoriaId = 1,
                Nombre = "Tomate rosa de la reina unidad (peso aprox. 900 gr)",
                UrlImagen = "/images/10937809993758.jpg",
                Descripcion = "Tomate rosa"
            });

            resultado.Add(new Producto()
            {
                Id = 6,
                CategoriaId = 1,
                Nombre = "Melón selección unidad (3.5 Kg aprox.)",
                UrlImagen = "/images/producto17p.jpg",
                Descripcion = "Melón"
            });

            resultado.Add(new Producto()
            {
                Id = 7,
                CategoriaId = 2,
                Nombre = "KOIPE Sol aceite girasol botella 1 lt",
                UrlImagen = "/images/11160116756510.jpg",
                Descripcion = "Aceite girasol"
            });

            resultado.Add(new Producto()
            {
                Id = 8,
                CategoriaId = 2,
                Nombre = "LAUKI leche desnatada envase 1 lt",
                UrlImagen = "/images/11238530220062.jpg",
                Descripcion = "Leche desnatada"
            });

            resultado.Add(new Producto()
            {
                Id = 9,
                CategoriaId = 2,
                Nombre = "KELLOGGS cereales corn flakes caja 500 gr",
                UrlImagen = "/images/11265824653342.jpg",
                Descripcion = "Cereales"
            });

            resultado.Add(new Producto()
            {
                Id = 10,
                CategoriaId = 2,
                Nombre = "FINI golosinas jelly cola bolsa 100 gr",
                UrlImagen = "/images/10905632178206.jpg",
                Descripcion = "FINI golosinas"
            });

            resultado.Add(new Producto()
            {
                Id = 11,
                CategoriaId = 3,
                Nombre = "RAPUN trenza de Huesca caja 450 gr",
                UrlImagen = "/images/10465404551198.jpg",
                Descripcion = "Trenza"
            });

            resultado.Add(new Producto()
            {
                Id = 110,
                CategoriaId = 3,
                Nombre = "DR OETKER ristorante pizza spinaci caja 390 gr",
                UrlImagen = "/images/11106487664670.jpg",
                Descripcion = "Pizza"
            });

            resultado.Add(new Producto()
            {
                Id = 12,
                CategoriaId = 4,
                Nombre = "Agua 50cl",
                UrlImagen = "/images/producto1p.jpg"
            });

            resultado.Add(new Producto()
            {
                Id = 13,
                CategoriaId = 4,
                Nombre = "Kas Naranja",
                UrlImagen = "/images/producto2p.jpg"
            });

            resultado.Add(new Producto()
            {
                Id = 14,
                CategoriaId = 4,
                Nombre = "Kas Limón",
                UrlImagen = "/images/producto3p.jpg"
            });

            resultado.Add(new Producto()
            {
                Id = 15,
                CategoriaId = 4,
                Nombre = "Pepsi",
                UrlImagen = "/images/producto4p.jpg"
            });

            resultado.Add(new Producto()
            {
                Id = 16,
                CategoriaId = 4,
                Nombre = "Pepsi Light",
                UrlImagen = "/images/producto5p.jpg"
            });

            resultado.Add(new Producto()
            {
                Id = 17,
                CategoriaId = 4,
                Nombre = "Pepsi Max",
                UrlImagen = "/images/producto6p.jpg"
            });

            resultado.Add(new Producto()
            {
                Id = 18,
                CategoriaId = 4,
                Nombre = "Seven Up",
                UrlImagen = "/images/producto9p.jpg"
            });

            return resultado;
        }
    }
}
