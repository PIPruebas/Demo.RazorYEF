using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Demo.RazorYEF.Data;
using Demo.RazorYEF.Entidades;

namespace Demo.RazorYEF.Pages.Productos
{
    public class CreateModel : PageModel
    {
        private readonly Demo.RazorYEF.Data.RazorDbContext _context;

        [ViewData]
        public SelectList Categorias { get; set; }

        public CreateModel(Demo.RazorYEF.Data.RazorDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Categorias = new SelectList(_context.Categorias, "Id", "Nombre");
            return Page();
        }

        [BindProperty]
        public Producto Producto { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Productos.Add(Producto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
