using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace FagElGamous.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
