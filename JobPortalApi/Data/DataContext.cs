using JobPortalApi.Models;
using System.Data.Entity;

namespace JobPortalApi.Data
{
    public class DataContext : DbContext
    {
       
            public DbSet<Student> Blogs { get; set; }
        public object Student { get; internal set; }
    }
}
}
