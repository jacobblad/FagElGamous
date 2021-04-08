using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


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
