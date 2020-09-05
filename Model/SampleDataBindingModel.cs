using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationTest.Model
{
    public class SampleDataBindingModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(1, 10000, ErrorMessage = "The Request Number must be between 1 and 10000")]
        public int RequestNumber { get; set; }
        [MaxLength(50, ErrorMessage = "Request Title length is more than 50")]
        public string RequestTitle { get; set; }
    }
}