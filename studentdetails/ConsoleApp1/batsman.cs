//using System;

//namespace ConsoleApp1
//{
//    class batsman
//    {
//        int bcode,innings,notout,runs;
//        string bname;
//        float batavg;

//        private float calcavg()
//        {
//            return (runs/(innings-notout));
//        }
//        public void readdata()
//        {
//            Console.WriteLine("Enter the Batsman code");
//            bcode = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Batsman name");
//            bname = Console.ReadLine();
//            Console.WriteLine("Enter no of innings played");
//            innings = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter no of notouts");
//            notout = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter no of runs batsman scored");
//            runs = Convert.ToInt32(Console.ReadLine());
           
//            batavg = calcavg();
//        }
//        public void displaydata()
//        {
//            Console.WriteLine($"Batsman name: {bname}");
//            Console.WriteLine($"Batsman code : {bcode}");
//            Console.WriteLine($"Innings:{innings}");
//            Console.WriteLine($"Runs:{runs}");
//            Console.WriteLine($"Notouts:{notout}");
//            Console.WriteLine($"Batting average: {batavg}");
//        }


//        static void Main(string[] args)
//        {
//            batsman stud = new batsman();
//            stud.readdata();
//            stud.displaydata();
//        }
//    }
//}
