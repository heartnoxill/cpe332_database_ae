using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace train_project_1.Models
{
    public class Ticket
    {
        [Key]
        public int T_id { get; set; }

        [DataType(DataType.Date)]
        public DateTime date_issued { get; set; }

        public int PassengerP_id { get; set; } // Passenger id
        public virtual Passenger Passenger { get; set; } // Fk in Passenger.cs
        public int TrainTR_id { get; set; } // Train id
        public virtual Train Train { get; set; } // Fk in Train
        public int ClassC_id { get; set; } // Class id
        public virtual Class Class { get; set; } // Fk in class
        public int R_id { get; set; } // Route id
        public virtual Route Route { get; set; } // Fk in Route.cs
        public DateTime ScheduleDeparture_date { get; set; } // Depature date in from schedule.cs
        public virtual Schedule Schedule { get; set; } // Fk in schedule.cs




    }
}
