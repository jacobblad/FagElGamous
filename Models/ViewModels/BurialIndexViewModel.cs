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

        public string? Gender { get; set; }

        public string? DirectionHead { get; set; }

        public string? HairColor { get; set; }

        public string? AgeRange { get; set; }

    }
}
