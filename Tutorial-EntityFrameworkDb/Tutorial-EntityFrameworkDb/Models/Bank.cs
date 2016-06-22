using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_EntityFrameworkDb.Models
{
    [Table("Bank")]
    public class Bank
    {
        [Key()]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Card> Cards { get; set; }
    }
}
