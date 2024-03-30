using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication10.Data;
using WebApplication10.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApplication10.Pages.Movies
{
    public class FilmDetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public FilmDetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
