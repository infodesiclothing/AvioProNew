using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace AvioProWeb.Models
{
    public class Cart
    {
        [StringLength(50)]
        public string PartNumber { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Brand { get; set; }
        [StringLength(50)]
        public string Units { get; set; }
    }
}