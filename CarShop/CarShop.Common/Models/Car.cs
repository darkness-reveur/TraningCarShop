using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarShop.Common.Models
{
    public class Car
    {
        public int Id { get; set; }

        public ushort ReleaseYear { get; set; }

        public double EngineVolume { get; set; }

        public double Price { get; set; }

        public int VehicleMileage { get; set; }

        public string Description { get; set; }

        public int BrandModelId { get; set; } // марка машины
        
        [ForeignKey("BrandModelId")]
        public virtual BrandModel BrandModel { get; set; }

        public int? OrderId { get; set; } // Положил ли кто то машину в карзину

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        public int? UserId { get; set; } // Есть ли у машины продавец, или из салона

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public enum EngineType
        {
            PetrolEngine,
            DieselEngine,
            ElectroEngine6
        }

        public enum WheelDrive
        {
            Front_WheelDrive,
            Real_WheelDrive,
            All_WheelDrive,
            Plug_In_All_Wheel_Drive
        }
    }
}
