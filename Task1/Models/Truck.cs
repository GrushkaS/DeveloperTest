using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class Truck : Vehicle
    {
        public Truck() : base(180, Enums.VehicleColor.Grey, "Volvo", 3500)
        {

        }
    }
}
