//using System;

//namespace ConsoleApp1
//{
//    class Test
//    {
//        int Testcode, NoCandidate, CenterReqd;
//        string Description;

//        private float CALCNTR()
//        {
//            return (NoCandidate / 100 + 1);
//        }
//        public void SCHEDULE()
//        {
//            Console.WriteLine("Enter the Test code");
//            Testcode = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Description");
//            Description = Console.ReadLine();
//            Console.WriteLine("Enter no of innings played");
//            NoCandidate = Convert.ToInt32(Console.ReadLine());

//            CenterReqd = (int)CALCNTR();
//        }
//        public void DISPTEST()
//        {
//            Console.WriteLine($"Test Code : {Testcode}");
//            Console.WriteLine($"Description : {Description}");
//            Console.WriteLine($"No of candidates : {NoCandidate}");
//            Console.WriteLine($"No of Centers required : {CenterReqd}");
//        }
//        static void Main(string[] args)
//        {
//            Test stud = new Test();
//            stud.SCHEDULE();
//            stud.DISPTEST();
//        }
//    }
//}
