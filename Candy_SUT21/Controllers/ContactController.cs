using Microsoft.AspNetCore.Mvc;

namespace Candy_SUT21.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
