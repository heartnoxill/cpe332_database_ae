using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace train_project_1.Models
{
    public class Passenger
    {
        [Key]
        public int P_id { get; set; }
        public string P_fname { get; set; }
        public string P_lname { get; set; }
        public string P_contact { get; set; }

        [DataType(DataType.Date)]
        public DateTime P_DOB { get; set; }

        public string Prefix { get; set; }
        public string Class_name { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } //Fk out --> Ticket.cs


    }
}
