using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace train_project_1.Models
{
    public class Promotion
    {
        [Key]
        public int Promotion_id { get; set; }

        public int Discount_percent { get; set; }

        [DataType(DataType.Date)]
        public DateTime Start_date { get; set; }

        [DataType(DataType.Date)]
        public DateTime Expiration_date { get; set; }
        public virtual ICollection<Price> Prices { get; set; } // Fk out price.cs
    }
}
