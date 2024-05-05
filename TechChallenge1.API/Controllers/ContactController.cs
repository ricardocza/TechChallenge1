using Microsoft.AspNetCore.Mvc;

namespace TechChallenge1.API.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
