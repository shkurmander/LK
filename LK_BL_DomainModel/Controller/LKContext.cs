using LK.BL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK.BL.DomainModel
{
    public class LKContext : DbContext
    {
        public LKContext() : base("DBConnect") { } 

        public DbSet<Abonent> Abonent { get; set; }
        public DbSet<AbonentTraffic> AbonentTraffics { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<TrafficType> TrafficTypes { get; set; }
    }
}
