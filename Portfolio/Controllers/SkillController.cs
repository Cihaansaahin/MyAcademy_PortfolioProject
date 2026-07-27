using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data;
using Portfolio.Data.Context; // AppDbContext'in bulunduğu namespace'i buraya ekleyin (örn: Portfolio.Data)

namespace Portfolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly AppDbContext _context; // DbContext adınız farklıysa güncelleyin (örn: PortfolioContext)

        // Dependency Injection ile veritabanı bağlantısını alıyoruz
        public SkillController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // About tablosunu çekerken ilişkili Skills tablosunu da Include ile yüklüyoruz
            var aboutList = await _context.Abouts
                .Include(a => a.Skills)
                .ToListAsync();

            return View(aboutList);
        }
    }
}