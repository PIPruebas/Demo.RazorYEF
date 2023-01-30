using System.ComponentModel.DataAnnotations;

namespace Demo.RazorYEF.Entidades
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [MaxLength(100, ErrorMessage = "La longitud de {0} tiene que ser como maximo {1}.")]
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? UrlImagen { get; set; }

        public List<Producto> Productos { get; set; }

        public Categoria()
        {
            Productos = new List<Producto>();
        }
    }
}
