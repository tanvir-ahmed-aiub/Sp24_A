using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIIntro.EF.Tbls
{
    public class User
    {
        [Key]
        [Required]
        [StringLength(10)]
        public string Username { get; set; }
        [Required]
        [StringLength (10)]
        public string Password { get; set; }
        public string Name { get; set; }
    }
}