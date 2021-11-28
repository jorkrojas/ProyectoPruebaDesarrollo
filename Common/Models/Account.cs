using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Common.Models
{
    public class Login
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
