using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DatabaseCodeFirst.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DatabaseCodeFirst.contextDB
{
    class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("database=BusCom;data source=.;integrated security=true") 
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            
            builder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            builder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Branch> Branches { get; set; }

    }
}
