using Microsoft.AspNetCore.Mvc;

namespace VascoVasconcellos.API.Areas.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("[area]/[controller]")]
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
