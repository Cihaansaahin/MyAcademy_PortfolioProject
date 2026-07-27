using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultAboutViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultAboutViewComponent(AppDbContext context)
        {
            _context = context;
        }
            public async Task<IViewComponentResult> InvokeAsync()
        {
            var about = await _context.Abouts
                .Include(a => a.Skills)
                .ToListAsync();

            return View(about);
        }
    }
}
