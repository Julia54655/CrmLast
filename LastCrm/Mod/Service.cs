using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCrm
{
   public class Service
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public virtual ICollection<Selling> Sellings { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public override int GetHashCode()
        {
            return Id;
        }
        public override bool Equals(object obj)
        {
            if (obj is Service service)
            {
                return Id.Equals(service.Id);
            }
            return false;
        }
    }
}
