using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace LAb1_SW
{
    class SageRep
    {
        public IEnumerable<Sage> GettAll() {
            var context = new SBContext();
            return context.Sages.Include("Book").ToList();
        }
        public void AddSage(Sage item) {
            var context = new SBContext();
            context.Sages.Add(item);
            context.SaveChanges();
        }
    }
}
