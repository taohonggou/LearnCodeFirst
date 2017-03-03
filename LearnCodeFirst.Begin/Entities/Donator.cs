using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LearnCodeFirst.Begin.Entities
{

    //[Table("Donator")]
    //public class Donator
    //{
    //    [Key]
    //    [Column("Id")]
    //    public int DonatorId { get; set; }
    //    [StringLength(maximumLength:10,MinimumLength =2)]
    //    public string Name { get; set; }
    //    public decimal Amount { get; set; }
    //    public DateTime DonateDate { get; set; }
    //}

    public class Donator
    {
        public int DonatorId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonateDate { get; set; }
    }

    public class DonatorMap: EntityTypeConfiguration<Donator>
    {
        public DonatorMap()
        {
            ToTable("DonatorFromConfig");//为了区分前面的Donators
            Property(o => o.DonatorId).HasColumnName("Id");
        }
    }
}
