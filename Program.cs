namespace Assignment7._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem garage = new(1, 1, 0);
            Console.WriteLine(garage.AddCar(1));
            Console.WriteLine(garage.AddCar(2));
            Console.WriteLine(garage.AddCar(3));
            Console.WriteLine(garage.AddCar(1));
        }

        public class ParkingSystem
        {
            public int Big { get; set; }
            public int Medium { get; set; }
            public int Small { get; set; }

            public ParkingSystem(int big, int medium, int small)
            {
                Big = big;
                Medium = medium;
                Small = small;
                return;


            }

            public bool AddCar(int carType)
            {
                if (carType == 1 && Big > 0)
                {
                    Big--;
                    return true;
                }
                else if (carType == 2 && Medium > 0)
                {
                    Medium--;
                    return true;
                }
                else if (carType == 3 && Small > 0)
                {
                    Small--;
                    return true;
                }
                else return false;
            }
        }
    }
}
