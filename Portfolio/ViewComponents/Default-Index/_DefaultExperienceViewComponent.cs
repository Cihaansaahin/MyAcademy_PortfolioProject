using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using System.Linq;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultExperienceViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        
        public _DefaultExperienceViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }
    }
}
