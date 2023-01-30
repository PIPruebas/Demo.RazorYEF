using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.RazorYEF.Entidades
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [MaxLength(100, ErrorMessage = "La longitud de {0} tiene que ser como maximo {1}.")]
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? UrlImagen { get; set; }

        [ForeignKey(nameof(Categoria))]
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set;}
    }
}
