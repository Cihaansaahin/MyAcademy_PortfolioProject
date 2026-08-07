using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly AppDbContext _context; 

       
        public SkillController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var skillList = await _context.Skills.ToListAsync();
            return View(skillList);
            //var aboutList = await _context.Abouts
            //    .Include(a => a.Skills)
            //    .ToListAsync();

            //return View(aboutList);
        }


        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSkill(Skill skill)
        {
            if (skill.AboutId == 0)
            {
                var defaultAbout = await _context.Abouts.FirstOrDefaultAsync();
                if (defaultAbout != null)
                {
                    skill.AboutId = defaultAbout.Id;
                }
            }

          await  _context.Skills.AddAsync(skill);
          await  _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var skil = _context.Skills.Find(id);
            return View(skil);
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var project = _context.Skills.Find(id);
            _context.Remove(project);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}