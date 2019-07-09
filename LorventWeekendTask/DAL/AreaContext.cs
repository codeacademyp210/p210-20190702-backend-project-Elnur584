using LorventWeekendTask.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LorventWeekendTask.DAL
{
    public class AreaContext:DbContext
    {
        public AreaContext():base("AreaConnection")
        {

        } 
        public DbSet<User> User{ get; set; }
        public DbSet<NewsAdd> NewsAdds { get; set; }
      
    }
}