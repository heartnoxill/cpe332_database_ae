using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace train_project_1.Models
{
    public class Route
    {
        [Key]
        public int R_id { get; set; }

        public int R_price { get; set; }
        public string Departure_station { get; set; }
        public string Departure_city { get; set; }
        public string Departure_state { get; set; }
        public string Destination_station { get; set; }
        public string Destination_city { get; set; }
        public string Destination_state { get; set; }
        public int Distance { get; set; }

        [DataType(DataType.Time)]
        public DateTime Duration { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } //Fk out ticket.cs
        public virtual ICollection<Schedule> Schedules { get; set; } // Fk out schedule.cs
        public virtual ICollection<Price> Prices { get; set; } // Fk out price.cs
    }
}
