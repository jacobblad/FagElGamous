using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Models.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Roles = new List<string>();
        }
        public string Id { get; set; }
        [Required][EmailAddress]
        public string Email { get; set; }
        public IList<string> Roles { get; set; }
    }
}
