using System;

namespace ConsoleApp1
{
    class Report
    {
        int adno;
        string name;
        int[] marks = new int[5];
        float average;
        private float GETAVG()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + marks[i];
            }
            return sum / 5;
        }
        public void ReadInfo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter the Admission number");
            adno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the marks of 5 subjects");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            average = GETAVG();
        }
        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The studen {name} with admission number {adno} scored {string.Join(", ", marks)} in 5 subjects. The average of the student is {average}.");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Main(string[] args)
        {
            Report f1 = new Report();
            f1.ReadInfo();
            f1.DisplayInfo();
        }
    }
}
