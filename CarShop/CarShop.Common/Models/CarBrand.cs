using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop.Common.Models
{
    public class CarBrand
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public List<BrandModel> BrandModels { get; set; } // чтобы была возможность указать модель данного бренда
    }
}
