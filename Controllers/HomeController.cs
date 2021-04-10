﻿using FagElGamous.Models;
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
        private IMummyRepository _repository;
        public int PageSize = 10;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult MultiDatabase()
        {
            using (mummiesdbContext db = new mummiesdbContext())
            {
                List<Burial> burials = db.Burial.ToList();
                List<Sample> samples = db.Sample.ToList();
                List<C14> C14s = db.C14.ToList();
                List<Cranial> cranials = db.Cranial.ToList();

                var mummyRecord = from b in burials
                                  join s in samples on b.BurialId equals s.BurialFk into table1
                                  from s in table1.ToList()
                                  join C in C14s on b.BurialId equals C.BurialFk into table2
                                  from C in table2.ToList()
                                      //join c in cranials on b.BurialId equals c.BurialFk into table3
                                      //from c in table3.ToList()
                                  select new ViewModel
                                  {
                                      burial = b,
                                      sample = s,
                                      c14 = C,
                                      //cranial = c
                                  };
                return View(mummyRecord);
            }
        }

        public IActionResult AllSites(/*int pageNum = 1*/)
        {
            return View();

            //pagination when we get DB set up
            /*return View(new ListViewModel
            {
                Sites = _repository.Sites
                    .Skip((pageNum - 1) * PageSize)
                    .Take(PageSize),
                Paginginfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Sites.Count()
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
