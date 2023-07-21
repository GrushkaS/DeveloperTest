namespace Task1.Models
{
    public class Car : Vehicle
    {
        private float engineCapacity { get; set; }
        public Car() : base(200, Enums.VehicleColor.Red, "Mazda", 3200)
        {
            EngineCapacity = 400.0f;
        }
        public float EngineCapacity
        {
            get { return engineCapacity; }
            set
            {
                if(value <= 0f || value > 2000f)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                engineCapacity = value;
            }
        }
    }
}
