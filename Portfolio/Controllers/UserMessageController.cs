using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.Controllers
{
    public class UserMessageController : Controller
    {
        private readonly AppDbContext _context;

        public UserMessageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var messages = _context.UserMessages.ToList();
            return View(messages);
        }

        [HttpGet]
        public IActionResult UserMessageDetail(int id)
        {
            var message = _context.UserMessages.Find(id);

            message.IsRead = true;
            _context.SaveChanges();
            return View(message);
        }

        public IActionResult DeleteUserMessage(int id)
        {
            var value = _context.UserMessages.Find(id); 
            if (value != null)
            {
                _context.UserMessages.Remove(value);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
