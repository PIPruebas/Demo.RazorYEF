using Demo.RazorYEF.Data;
using Demo.RazorYEF.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Demo.RazorYEF.Negocio
{
    public class ProductosNegocio
    {
        private readonly RazorDbContext _context;

        public ProductosNegocio(RazorDbContext context)
        {
            _context = context;
        }

        public List<Producto> ObtenerProductos()
        {
            return _context.Productos.Include(x => x.Categoria).ToList();
        }

        public Producto? ObtenerProducto(int productoId)
        {
            return _context.Productos.Where(x => x.Id == productoId).Include(x => x.Categoria).FirstOrDefault();
        }

        public Producto? ObtenerProductoDeCategoria(int productoId, int categoriaId = 0)
        {
            // LO CORRECTO
            var consulta = _context.Productos.Include(x=>x.Categoria).AsQueryable();

            if(categoriaId != 0)
            {
                consulta = consulta.Where(x => x.CategoriaId == categoriaId);
            }

            return consulta.FirstOrDefault();
        }
    }
}
