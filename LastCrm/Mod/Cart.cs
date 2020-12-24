using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCrm.Mod
{
    public class Cart : IEnumerable
    {
        public Client Client { set; get; }
        public Dictionary<Service, int> Servises { set; get; }

        public Cart(Client client)
        {
            Client = client;
            Servises = new Dictionary<Service, int>();

        }

       

        public void Add(Service service)
        {
            if(Servises.TryGetValue(service,out int count))
            {
                Servises[service] = ++count;
            }else
            { Servises.Add(service, 1); }
        }


        public IEnumerator GetEnumerator()
        {
          foreach(var service in Servises.Keys)
            {
                yield return service;
            }
        }

        public List<Service> GetServices()
        {
            var result = new List<Service>();
                foreach( Service i in this)
            {
                result.Add(i);
            }
            return result;
        }
    }
}
