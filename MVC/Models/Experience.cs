using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Experience
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string WorkRole { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        [Required]
        public string Description { get; set; }
    }
}