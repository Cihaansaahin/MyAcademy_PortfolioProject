using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class EducationController : Controller
    {
        private readonly AppDbContext _context;

        public EducationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Educations.ToList();
            return View(values);
            
        }


        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            _context.Educations.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var value = _context.Educations.Find(id);
            return View(value);
            
        }

        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            _context.Educations.Update(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEducation(int id)
        {
            var value = _context.Educations.Find(id);
            _context.Educations.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
