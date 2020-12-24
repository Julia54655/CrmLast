using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCrm
{
   public class Selling
    {
        public int Id { get; set; }
        public int Check1Id { get; set; }
        public virtual Check1 Checks { get; set; }

        public int ServiceId { get; set; }

        public virtual Service Services { get; set; }


    }
}
