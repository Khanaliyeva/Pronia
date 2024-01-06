using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pronia.Core.Entities.Common;
using Microsoft.AspNetCore.Http;

namespace Pronia.Core.Entities
{
    public class Slider:BaseEntity
    {
        [Required, StringLength(30, ErrorMessage = "The maximum length can be 30")]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        [StringLength(maximumLength: 100)]
        public string? ImgUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
