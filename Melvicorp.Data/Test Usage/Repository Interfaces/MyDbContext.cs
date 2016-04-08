using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Melvicorp.Data.Test
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=main")
        {
            Database.SetInitializer<MyDbContext>(null);
        }

        public DbSet<FieldGroup> FieldGroupSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Ignore<IIdentifiableEntity<int>>();

            modelBuilder.Entity<FieldGroup>().HasKey<int>(e => e.FieldGroupId).Ignore(e => e.EntityId);
        }
    }
}
