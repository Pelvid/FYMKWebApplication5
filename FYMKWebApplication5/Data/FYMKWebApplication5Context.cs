using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FYMKWebApplication5.Data
{
    public class FYMKWebApplication5Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FYMKWebApplication5Context() : base("name=FYMKWebApplication5Context")
        {
        }

        public System.Data.Entity.DbSet<FYMKWebApplication4.Models.Mentee> Mentees { get; set; }

        public System.Data.Entity.DbSet<FYMKWebApplication4.Models.Mentor> Mentors { get; set; }

        public System.Data.Entity.DbSet<FYMKWebApplication5.Models.AdminDashboard> AdminDashboards { get; set; }

        public System.Data.Entity.DbSet<FYMKWebApplication5.Models.Profile> Profiles { get; set; }

        public System.Data.Entity.DbSet<FYMKWebApplication5.Models.Verify> Verifies { get; set; }

        public System.Data.Entity.DbSet<FYMKWebApplication5.Models.ProfileSettings> ProfileSettings { get; set; }
    }
}
