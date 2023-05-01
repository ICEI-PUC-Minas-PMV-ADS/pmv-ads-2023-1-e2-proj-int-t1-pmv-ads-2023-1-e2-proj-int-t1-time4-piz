using Microsoft.AspNetCore.Mvc;

namespace PizzApp.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
                return View(); 
        }
    }
}
