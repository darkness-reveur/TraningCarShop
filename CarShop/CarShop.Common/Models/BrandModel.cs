using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarShop.Common.Models
{
    public class BrandModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Car> Cars { get; set; }

        public int CarBrandId { get; set; }

        [ForeignKey("CarBrandId")]
        public virtual CarBrand CarBrand { get; set; }
    }
}
