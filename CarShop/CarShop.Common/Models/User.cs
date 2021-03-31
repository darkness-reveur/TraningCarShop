using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarShop.Common.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        public int? CarId { get; set; } // продаёт ли пользователь машину и какую
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
    }
}
