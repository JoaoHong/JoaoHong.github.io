using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace VascoVasconcellos.API.Modulos.Etiquetas.Controllers
{
    public class EtiquetaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
