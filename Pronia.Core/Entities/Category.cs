using Pronia.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Core.Entities
{
    public class Category:BaseEntity

    {
        [StringLength(maximumLength: 10, ErrorMessage = "Length can't be more than 10")]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
