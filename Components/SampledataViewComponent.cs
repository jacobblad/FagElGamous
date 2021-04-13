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
            //Return all the samples
            return View(context.Sample
                //.Select(x => x.BurialFk)//Select the row of samples with matching Burial identifiers
                //.Where(x => x.BurialFK == givenBurialId)
                .Distinct()
                .OrderBy(x => x)
                .ToList());
        }
    }
}
