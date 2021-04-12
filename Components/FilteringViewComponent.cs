using FagElGamous.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Components
{
    public class FilteringViewComponent : ViewComponent
    {
        private mummiesdbContext context;
        public FilteringViewComponent(mummiesdbContext ctx)
        {
            context = ctx;
        }
        public IViewComponentResult Invoke()
        {
            return View(context.Burial
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
