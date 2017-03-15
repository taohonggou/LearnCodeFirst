using LearnCodeFirst.Begin.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCodeFirst.Begin
{
    public class Context : DbContext
    {
        public Context() : base("name=FirstCodeFirstApp")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Donator>().ToTable("Donators").HasKey(o => o.DonatorId);//将Donator类映射到Donators表中，并且DonatorId是主键
            //modelBuilder.Entity<Donator>().Property(m => m.DonatorId).HasColumnName("Id");//将DonatorID在数据库的对应的字段为Id

            //modelBuilder.Entity<Donator>().Property(m => m.Name).IsRequired()
            //    .IsUnicode().
            //    HasMaxLength(10);

            modelBuilder.Configurations.Add(new DonatorMap());
            modelBuilder.Configurations.Add(new DonatorTypeMap());
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Donator> Donators { get; set; }
        public DbSet<PayWay> PayWays { get; set; }
        public DbSet<DonatorType> DonatorTypes { get; set; }

    }
}
