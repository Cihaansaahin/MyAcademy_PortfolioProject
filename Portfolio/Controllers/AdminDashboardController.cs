using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using System.Linq;

namespace Portfolio.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly AppDbContext _context;

        public AdminDashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Metrik/İstatistik Bilgileri
            ViewBag.TotalMessages = _context.UserMessages.Count();
            ViewBag.UnreadMessages = _context.UserMessages.Count(m => !m.IsRead);
            ViewBag.TotalProjects = _context.Projects.Count();
            ViewBag.TotalExperiences = _context.Experiences.Count();
            ViewBag.TotalSkills = _context.Skills.Count();

            // Son Eklenen 5 Proje
            var recentProjects = _context.Projects
                                         .OrderByDescending(p => p.Id)
                                         .Take(5)
                                         .ToList();

            return View(recentProjects);
        }
    }
}