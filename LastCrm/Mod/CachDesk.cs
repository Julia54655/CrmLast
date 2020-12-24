using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LastCrm;

namespace LastCrm.Mod
{
   public class CachDesk
    {
        ContextCrm db = new ContextCrm();
        public int Number { set; get; }
        public Specialist Specialist { set; get; }
        public Queue<Cart> ClientQueue { get; set; }

        public int MaxQueueLenght { set; get; }

        public int ExitClient { get; set; }

        public bool isModel { set; get; }

        public CachDesk(int number, Specialist specialist)
        {
            Number = number;
            Specialist = specialist;
            ClientQueue = new Queue<Cart>();
            isModel = true;

        }

        public void Enqueue(Cart cart)
        {
            if (ClientQueue.Count <= MaxQueueLenght)
            {
                ClientQueue.Enqueue(cart);
            }else
            {
                ExitClient++;
            }

        }

        public void Dequeue()
        {
            var card = ClientQueue.Dequeue();
            if (card != null)
            {
                var check = new Check1()
                {
                    Specialists = Specialist,
                    SpecialistId = Specialist.Id,

                    Client = card.Client,
                    ClientId = card.Client.Id,
                    Date = DateTime.Now

                };
                if (!isModel)
                {
                    db.Checks.Add(check);
                    db.SaveChanges();
                }
                else
                {
                    check.Id = 0;
                }
                foreach (Service service in card)
                {
                    var selling = new Selling()
                    {
                        Check1Id = check.Id,
                        Checks = check,
                        Services = service,
                        ServiceId = service.Id
    
                    
                    };
                }
            }
        }
    }
}
