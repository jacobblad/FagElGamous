using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Models
{
    public class EFMummyRepository : IMummyRepository
    {
        private MummyDbContext _context;

        //Constructor
        public EFMummyRepository(MummyDbContext context)
        {
            _context = context;
        }
        public IQueryable<Site> Sites => _context.Sites;
    }
}
