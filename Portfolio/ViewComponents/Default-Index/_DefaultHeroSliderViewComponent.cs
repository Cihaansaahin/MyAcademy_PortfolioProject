using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultHeroSliderViewComponent :ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultHeroSliderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var abaout = _context.Banners.ToList();
            return View(abaout);
        }
    }
}
