using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop.Common.Models
{
    public class CarBrand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<BrandModel> BrandModels { get; set; }
    }
}
