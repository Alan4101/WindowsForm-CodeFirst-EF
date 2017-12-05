using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb1_SW
{
    public class Sage
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String Photo { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Books> Book { get; set; }
        public Sage()
        {
            Book = new List<Books>();
        }


    }
}
