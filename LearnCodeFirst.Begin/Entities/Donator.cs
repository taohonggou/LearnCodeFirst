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
        public Donator()
        {
            //为了避免潜在的null引用异常可能性，当Donator对象创建时，我们使用HashSet的T集合类型实例创建一个新的集合实例，如下所示：
            PayWays = new HashSet<PayWay>();
        }

        public int DonatorId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonateDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<PayWay> PayWays { get; set; }

        public int? DonatorTypeId { get; set; }

        public virtual DonatorType DonatorType { get; set; }
    }

    public class DonatorMap : EntityTypeConfiguration<Donator>
    {
        public DonatorMap()
        {
            ToTable("Donators");//为了区分前面的Donators
            //Property(o => o.DonatorId).HasColumnName("Id");
            Property(o => o.Name).IsRequired();

            HasMany(o => o.PayWays).
                WithRequired().HasForeignKey(p => p.DonatorId);
        }
    }
}
