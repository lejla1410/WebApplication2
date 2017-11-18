using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ORM.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("TestDB")
        {

        }
        public DbSet<TestDBModel> TestDBModels { get; set; }

    }
}