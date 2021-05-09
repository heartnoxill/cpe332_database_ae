using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace train_project_1.Models
{
    public class Train
    {
        [Key]
        public int TR_id { get; set; }
        public DateTime TR_age { get; set; }
        public int Maxspeed { get; set; }
        public string Status { get; set; }
        public int Max_cap { get; set; }
        public int Seats_filled { get; set; }
        public int Seats_remain { get; set; }
        public int Platform { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; } //Fk out Staff.cs
        public virtual ICollection<Ticket> Tickets { get; set; } //Fk out Ticket.cs
    }
}
