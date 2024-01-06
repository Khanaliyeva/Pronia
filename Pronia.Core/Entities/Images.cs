using Pronia.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Core.Entities
{
    public class Images:BaseEntity
    {
        public string ImgUrl { get; set; }
        public bool? IsPrime { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
