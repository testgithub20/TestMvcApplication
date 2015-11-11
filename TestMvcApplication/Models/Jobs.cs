using System.Collections.Generic;
using System.Data.Entity;

namespace TestMvcApplication.Models
{    
    public class Jobs
    {
        public string client { get; set; }
        public int jobnumber { get; set; }
        public string jobname { get; set; }
        public string due { get; set; }
        public string status { get; set; }
    }

    public class RootObject
    {
        public List<Jobs> jobs { get; set; }
    }

    public class JobsDBContext : DbContext
    {
        public DbSet<Jobs> Jobs { get; set; }
    }
}