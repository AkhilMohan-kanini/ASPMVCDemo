using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPMVCDemo.Models
{
    public class ReleaseManagementContext : DbContext
    {

        public ReleaseManagementContext():base("connRB")
            {
            }

        public  DbSet<Employee> Employees { get; set; }

        public  DbSet<LoginDetails> LoginDetails { get; set; }
    }


}