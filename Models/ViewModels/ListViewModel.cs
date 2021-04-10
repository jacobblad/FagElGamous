using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FagElGamous.Models.ViewModels;

namespace FagElGamous.Models.ViewModels
{
    public class ListViewModel
    {
        public PagingInfo Paginginfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
