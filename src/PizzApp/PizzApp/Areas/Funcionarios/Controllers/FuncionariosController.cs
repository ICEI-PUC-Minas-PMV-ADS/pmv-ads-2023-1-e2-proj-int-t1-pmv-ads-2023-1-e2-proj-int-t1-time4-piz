using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PizzApp.Areas.Funcionarios.Controllers
{
    [Area("Funcionarios")]
    [Authorize("Funcionarios")]
    public class FuncionariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
