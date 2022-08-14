namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //var vehicle = new Vehicle(100, 100);

            //vehicle.Drive(3);
            var v = new SportCar(100, 100);
            System.Console.WriteLine(v.FuelConsumption);
        }
    }
}
