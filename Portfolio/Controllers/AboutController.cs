using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;
using System.Linq;

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {

        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var about = _context.Abouts.FirstOrDefault();
            return View(about);
        }
        [HttpGet] 
        public IActionResult CreateAbout()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
           _context.Abouts.Add(about);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


      public IActionResult UpdateAbout(int Id)
        {
            var about = _context.Abouts.Find(Id);
            return View(about);
        }

        [HttpPost]

        public IActionResult UpdateAbout(About about)
        {

            _context.Abouts.Update(about);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAbout(int Id)
        {
            var about = _context.Abouts.Find(Id);
            _context.Abouts.Remove(about);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
