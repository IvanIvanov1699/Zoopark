using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoopark.Model;

namespace Zoopark.DbContexts
{
    public class ZooDatabaseContext : DbContext
    {
        public ZooDatabaseContext() : base(Properties.Settings.Default.DbConnect)
        {

        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventTypes> EventTypes { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<SoldTickets> SoldTickets { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public object User { get; internal set; }
    }
}
