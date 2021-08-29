using System;

namespace Tasks
{
    class max_min
    {
        static void Main(string[] args)
        {
            int n, max=0,min=999999;
            int flag = 0;


            do
            {
                Console.WriteLine("Enter the Numbers");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
                Console.WriteLine("WANT TO ADD ANOTHER NUMBER PRESS 1 ELSE PRESS 0");
                flag = Convert.ToInt32(Console.ReadLine());
            } while (flag == 1);
            Console.WriteLine($"maximum: {max}, Minimum: {min}");
        }
    }
}
