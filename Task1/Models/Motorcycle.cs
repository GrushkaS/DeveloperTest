namespace Task1.Models
{
    public class Motorcycle : Vehicle
    {
        private int gears { get; set; }
        public Motorcycle() : base(150, Enums.VehicleColor.Yellow, "Yamaha", 1600.5)
        {
            Gears = 5;
        }
        public int Gears
        {
            get { return gears; }
            set
            {
                if(value <= 0 || value > 7)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                gears = value;
            }
        }
    }
}
