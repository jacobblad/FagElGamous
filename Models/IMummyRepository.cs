using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Models
{
    public interface IMummyRepository
    {
        IQueryable<Site> Sites { get; }
    }
}
