﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Models.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<IdentityUser> Users { get; set; }

    }
}
