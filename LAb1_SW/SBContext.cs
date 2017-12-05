using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LAb1_SW
{
   public class SBContext :DbContext
    {
       // public UserContext() : base("") { }

        public DbSet<Books> Book { get; set; }
        public DbSet<Sage> Sages { get; set; }
    }
}
