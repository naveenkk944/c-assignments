//using System;

//namespace ConsoleApp1
//{
//    class student
//    {
//        int admno;
//        string sname;
//        float eng, math, science, total;

//        private float ctotal()
//        {
//            return (eng + math + science);
//        }
//        public void Takedata()
//        {
//            Console.WriteLine("Enter the admission number");
//            admno=Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Student name");
//            sname = Console.ReadLine();
//            Console.WriteLine("Enter the english marks");
//            eng = Convert.ToSingle(Console.ReadLine());
//            Console.WriteLine("Enter the mathematics marks");
//            math = Convert.ToSingle(Console.ReadLine());
//            Console.WriteLine("Enter the science marks");
//            science = Convert.ToSingle(Console.ReadLine());
//            total = ctotal();
//        }
//        public void Showdata()
//        {
//            Console.WriteLine($"Admission number is {admno}");
//            Console.WriteLine($"Student name : {sname}");
//            Console.WriteLine($"English marks:{eng}");
//            Console.WriteLine($"Mathematics marks:{math}");
//            Console.WriteLine($"Science marks:{science}");
//            Console.WriteLine($"Total marks: {total}");
//        }


//        static void Main(string[] args)
//        {
//            student stud = new student();
//            stud.Takedata();
//            stud.Showdata();
//        }
//    }
//}
