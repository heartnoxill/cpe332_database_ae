using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace train_project_1.Models
{
    public class Price
    {
        public float TotalPrice { get; set; }

        [Key]
        public int TicketT_id { get; set; }
        public virtual Ticket Ticket { get; set; } // Fk in Ticket.cs

        public int ClassC_id { get; set; } // Class id
        public virtual Class Class { get; set; } // Fk in Class.cs

        public int PromotionPromotion_id { get; set; } // Promotion id
        public virtual Promotion Promotion { get; set; } // Fk in Promotion.cs

        public int RouteR_id { get; set; } // Route id
        public virtual Route Route { get; set; } // Fk in Route.cs
        
    }
}
