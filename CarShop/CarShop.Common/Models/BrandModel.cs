using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarShop.Common.Models
{
    public class BrandModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CarBrandId { get; set; }

        [ForeignKey("CarBrandId")]
        public virtual CarBrand CarBrand { get; set; }

        public virtual List<Car> Cars { get; set; }
    }
}
