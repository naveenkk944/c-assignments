//using System;

//namespace ConsoleApp1
//{
//    class Flight
//    {
//        int Flight_number;
//        string Destination;
//        float Distance, Fuel;
//        private float CALFUEL()
//        {
//            if (Distance <= 1000)
//                return 500;
//            else if (Distance <= 2000)
//                return 1100;
//            else if (Distance > 2000)
//                return 2200;
//            return 0;
//        }
//        public void FEEDINFO()
//        {
//            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.WriteLine("Enter the Flight number");
//            Flight_number = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Destination");
//            Destination = Console.ReadLine();
//            Console.WriteLine("Enter distance between the two places");
//            Distance = Convert.ToSingle(Console.ReadLine());
//            Fuel = CALFUEL();
//        }
//        public void SHOWINFO()
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine($"The flight with number {Flight_number} travelling to the destination {Destination} over a distance of {Distance} requires a fuel {Fuel}.");
//            Console.ForegroundColor = ConsoleColor.Black;
//        }
//        static void Main(string[] args)
//        {
//            Flight f1 = new Flight();
//            f1.FEEDINFO();
//            f1.SHOWINFO();
//        }
//    }
//}
