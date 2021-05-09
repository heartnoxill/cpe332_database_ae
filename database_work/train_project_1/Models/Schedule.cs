using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace train_project_1.Models
{
    public class Schedule
    {
        [DataType(DataType.Date)]
        public DateTime Departure_date { get; set; }

        [DataType(DataType.Time)]
        public DateTime CheckIn_time { get; set; }

        [DataType(DataType.Time)]
        public DateTime Departure_time { get; set; }

        [Key]
        public int RouteR_id { get; set; } // Route id
        public virtual Route Routes { get; set; } // Fk in route.cs
        
        public virtual ICollection<Ticket> Tickets { get; set; } // Fk out ticket.cs
    }
}
