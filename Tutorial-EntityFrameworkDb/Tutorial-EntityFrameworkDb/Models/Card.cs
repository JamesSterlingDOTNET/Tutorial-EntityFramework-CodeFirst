using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_EntityFrameworkDb.Models
{
    [Table("Card")]
    public class Card
    {
        [Key(), ForeignKey("Customer")]
        public Guid Id { get; set; }
        public int Pin { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Bank")]
        public Guid BankId { get; set; }
        public Bank Bank { get; set; }
    }
}
