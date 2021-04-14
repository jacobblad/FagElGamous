using FagElGamous.Models;
using FagElGamous.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FagElGamous.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private mummiesdbContext _context;
        public int PageSize = 10;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public Burial GetTableField()
        {
            Burial testqfd = new Burial();

            return testqfd;
        }


        public IActionResult AllSites(/*int pageNum = 1*/)
        {
            return View();

            //pagination when we get DB set up
            /*return View(new ListViewModel
            {
                Sites = _context.Sites
                    .Skip((pageNum - 1) * PageSize)
                    .Take(PageSize),
                Paginginfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _context.Sites.Count()
                },
            });*/
        }

        public IActionResult AccountInfo()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
