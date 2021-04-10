using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Models.ViewModels
{
    public class ViewModel
    {
        public Burial burial { get; set; }
        public Sample sample { get; set; }
        public C14 c14 { get; set; }
        public Cranial cranial { get; set; }
    }
}
