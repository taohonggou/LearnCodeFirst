using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LearnCodeFirst.Begin.Entities
{
    [Table("PayWay")]
    public class PayWay
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(8)]
        public string Name { get; set; }
    }
}
