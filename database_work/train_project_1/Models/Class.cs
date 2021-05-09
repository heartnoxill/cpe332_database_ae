using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace train_project_1.Models
{
    public class Class
    {
        [Key]
        public int C_id { get; set; }
        public string Classname { get; set; }
        public int Class_price { get; set; }
        public int Aisle_no { get; set; }
        public int Seat_no { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; } // Fk out
        public virtual ICollection<Price> Prices { get; set; } // FK out to price
    }
}
