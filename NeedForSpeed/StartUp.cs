namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var vehicle = new Vehicle(100, 100);

            vehicle.Drive(3);
        }
    }
}
