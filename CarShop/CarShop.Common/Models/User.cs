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
    }
}
