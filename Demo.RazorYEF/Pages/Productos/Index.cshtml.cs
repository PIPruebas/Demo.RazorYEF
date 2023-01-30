using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Demo.RazorYEF.Data;
using Demo.RazorYEF.Entidades;

namespace Demo.RazorYEF.Pages.Productos
{
    public class IndexModel : PageModel
    {
        private readonly Demo.RazorYEF.Data.RazorDbContext _context;

        public IndexModel(Demo.RazorYEF.Data.RazorDbContext context)
        {
            _context = context;
        }

        public IList<Producto> Producto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Productos != null)
            {
                Producto = await _context.Productos
                .Include(p => p.Categoria).ToListAsync();
            }
        }
    }
}
