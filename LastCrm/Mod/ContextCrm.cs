using System.Data.Entity;


namespace LastCrm
{
   public class ContextCrm:DbContext
    {

        public ContextCrm() : base("CrmConnect") { }

        public DbSet<Check1> Checks { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Selling> Sellings { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<Specialist> Specialists { get; set; }

    }
}
