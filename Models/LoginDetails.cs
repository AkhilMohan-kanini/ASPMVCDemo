using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPMVCDemo.Models
{
    public class LoginDetails
    {
        
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string UserRole { get; set; }

      
    }
}