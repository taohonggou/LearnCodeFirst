using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
}
