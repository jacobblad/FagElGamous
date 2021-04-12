using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Models.ViewModels
{
    public class BurialIndexViewModel
    {
        public List<Burial> Burials { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
