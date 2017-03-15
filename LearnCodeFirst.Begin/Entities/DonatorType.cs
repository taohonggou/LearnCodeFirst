using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCodeFirst.Begin.Entities
{
    public class DonatorType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Donator> Donators { get; set; }
    }

    public class DonatorTypeMap : EntityTypeConfiguration<DonatorType>
    {
        public DonatorTypeMap()
        {
            HasMany(dt => dt.Donators).WithOptional(d => d.DonatorType).HasForeignKey(o => o.DonatorTypeId).WillCascadeOnDelete(false);
        }
    }
}
