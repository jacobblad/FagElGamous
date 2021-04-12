using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Models
{
    public class Filter
    {
        [Required]
        [DisplayName("Field Name")]
        public string FieldName { get; set; }
        [Required]
        [DisplayName("Field Value")]
        public string FieldValue { get; set; }

    }
}
