using FagElGamous.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Components
{
    public class FilterViewComponent : ViewComponent
    {
        private mummiesdbContext context;
        public FilterViewComponent(mummiesdbContext con)
        {
            context = con;
        }

        public IViewComponentResult Invoke()
        {
            //filters so it grabs the list of gender types
            return View(context.Burial
                .Select(x => x.GenderGe)
                .Distinct()
                .OrderBy(x => x)
                .ToList()); //returns the default view that corresponse to this componet
        }
    }
}
