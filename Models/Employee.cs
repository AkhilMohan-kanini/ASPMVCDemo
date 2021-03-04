using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPMVCDemo.Models
{
    public class Employee
    {
        public int UserID { get; set; }

        [Key]
        public string EmployeeName { get; set; }

        public string EmployeeRole { get; set; }

        [ForeignKey("UserID")]
        public LoginDetails Login { get; set; }
    }
}