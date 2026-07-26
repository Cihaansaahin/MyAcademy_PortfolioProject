using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{

    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly AppDbContext _context;
        public DefaultController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(UserMessage userMesage)
        {
            _context.UserMessages.Add(userMesage);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
