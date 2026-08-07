using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultFooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultFooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var abaout = _context.ContactInfos.FirstOrDefault();
            return View(abaout);
        }
    }
}
