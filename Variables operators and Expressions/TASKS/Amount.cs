using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    class Amount
    {
        static void Main(string[] args)
        {
            int Amount;
            int num500, num100, num50, num20, num10, num5, num2, num1,rem;
            Console.WriteLine("Enter total number of days");
            Amount = Convert.ToInt32(Console.ReadLine());
            num500 = Amount / 500;
            rem = Amount % 500;
            num100 = rem / 100;
            rem = rem % 100;
            num50 = rem / 50;
            rem = rem % 50;
            num20 = rem / 20;
            rem = rem % 20;
            num10 = rem / 10;
            rem = rem % 10;
            num5 = rem / 5;
            rem = rem % 5;
            num2 = rem / 2;
            rem = rem % 2;
            num1 = rem / 1;
            rem = rem % 1;

            Console.WriteLine($"The change is {num500} 500's,{num100} 100's,{num50} 50's,{num20}20's,{num10} 10's,{num5} 5's,{num2} 2's,{num1} 1's");
        }
    }
}
