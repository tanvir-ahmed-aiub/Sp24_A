using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission.Models
{
    public class Person
    {
        [Required]
        [StringLength(50,ErrorMessage ="My Error")]
        public string Name { get; set; }
        [Required]
        [StringLength(5,MinimumLength =2)]
        public string Username { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
        [Required]
        [Range(1,40)]
        public int Roll { get; set; }
    }
}