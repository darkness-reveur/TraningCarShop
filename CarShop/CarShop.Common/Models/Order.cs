using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarShop.Common.Models
{
    public class Order
    {
        public int Id { get; set; }

        public double Sum { get; set; }

        public DateTime Date { get; set; }

        public List<Car> Cars { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
