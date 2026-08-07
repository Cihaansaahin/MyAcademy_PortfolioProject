using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class BannerController : Controller
    {
        private readonly AppDbContext _context;

        public BannerController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var banners = _context.Banners.ToList();
            return View(banners);
        }

        [HttpGet]
        public IActionResult CreateBanner()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBanner(Banner banner)
        {
            if (!ModelState.IsValid)
            {
                return View(banner);
            }

            _context.Banners.Add(banner);
            _context.SaveChanges();
            return RedirectToAction("Index","Banner");
        }

        [HttpGet]
        public IActionResult UpdateBanner(int id)
        {
            var banner = _context.Banners.Find(id);
            if (banner == null)
            {
                return NotFound();
            }
            return View(banner);
        }

        [HttpPost]
        public IActionResult UpdateBanner(Banner banner)
        {
            if (!ModelState.IsValid)
            {
                return View(banner);
            }

            _context.Update(banner);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBanner(int id)
        {
            var banner = _context.Banners.Find(id);
            if (banner != null)
            {
                _context.Remove(banner);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}