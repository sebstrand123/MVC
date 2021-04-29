using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Skills
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Description { get; set; }
    }
}