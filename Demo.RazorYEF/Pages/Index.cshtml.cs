using Demo.RazorYEF.Entidades;
using Demo.RazorYEF.Negocio;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo.RazorYEF.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ProductosNegocio _productosNegocio;

        public List<Producto> Productos { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ProductosNegocio productosNegocio)
        {
            _logger = logger;
            _productosNegocio = productosNegocio;
        }

        public void OnGet()
        {
            Productos = _productosNegocio.ObtenerProductos();
        }
    }
}