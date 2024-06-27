using Microsoft.AspNetCore.Mvc;
using WebApplication_1.Models;

namespace WebApplication_1.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
