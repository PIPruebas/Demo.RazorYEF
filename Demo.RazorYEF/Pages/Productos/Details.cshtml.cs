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
    public class DetailsModel : PageModel
    {
        private readonly Demo.RazorYEF.Data.RazorDbContext _context;

        public DetailsModel(Demo.RazorYEF.Data.RazorDbContext context)
        {
            _context = context;
        }

      public Producto Producto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            else 
            {
                Producto = producto;
            }
            return Page();
        }
    }
}
