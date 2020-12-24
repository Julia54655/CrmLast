using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCrm
{
   public  class Check1
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }

        public int SpecialistId { get; set; }
        public virtual Specialist Specialists { get; set; }

        public DateTime Date { get; set; }
        public virtual ICollection<Selling> Sellings { get; set; }



        public override string ToString()
        {
            return $"№{Id} from {Date.ToString("dd.MM.yy HH:mm:ss")}";
        }

    }
}
