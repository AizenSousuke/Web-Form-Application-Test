using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationTest.Model
{
    public class Model1
    {
        [Required]
        public int RequestNumber { get; set; }
        [MinLength(3)]
        public string Name { get; set; }
    }
}