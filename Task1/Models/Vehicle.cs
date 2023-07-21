using Task1.Models.Enums;

namespace Task1.Models
{
    public abstract class Vehicle
    {
        private int maxSpeed;

        public Vehicle(int maxSpeed, VehicleColor vehicleColor, string model, double price) 
        {
            MaxSpeed = maxSpeed;
            Color = vehicleColor;
            Model = model;
            Price = price;
        }



        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            private set
            {
                if(value < 0 || value > 300)
                    throw new ArgumentOutOfRangeException(nameof(value));

                maxSpeed = value;
            }
        }

        public VehicleColor Color { get; set; }
        public string? Model { get; private set; }
        public double Price { get; set; }
    }
}
