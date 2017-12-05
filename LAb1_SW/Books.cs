using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb1_SW
{
   public class Books
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Year { get; set; }

        public virtual ICollection<Sage> Sages { get; set; }

        public Books()
        {
            Sages = new List<Sage>();
        }
    }
}
