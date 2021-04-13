using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Models.ViewModels
{
    public class PagingInfo
    {
        public int NumItemsPerPage { get; set; }
        public int CurrentPage { get; set; } //which page to highlight
        public int TotalNumItems { get; set; }
        
        //calc the number of pages
        public int NumPages => (int)(Math.Ceiling((decimal)TotalNumItems / NumItemsPerPage));
    }
}
