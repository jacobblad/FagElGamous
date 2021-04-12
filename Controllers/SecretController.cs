using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace FagElGamous.Controllers
{
    [Authorize(Roles = "Admin, Researcher")]
    public class SecretController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
