using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FagElGamous.Models;
using Microsoft.AspNetCore.Mvc;

namespace FagElGamous.Components
{
    public class SampledataViewComponent : ViewComponent
    {
        private mummiesdbContext context;

        public SampledataViewComponent (mummiesdbContext con)
        {
            context = con;
        }

        public IViewComponentResult Invoke()
        {
            return View(context.Burial
                .Select(x => x.BurialId)
                .Distinct()
                .OrderBy(x => x)
                .ToList());
        }
    }
}
