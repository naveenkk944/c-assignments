//using System;

//namespace Tasks
//{
//    class pos_neg_count
//    {
//        static void Main(string[] args)
//        {
//            int n, poscount=0, negcount=0, zerocount=0;
//            int flag=0;
            
            
//            do
//            {
//                Console.WriteLine("Enter the Numbers");
//                n = Convert.ToInt32(Console.ReadLine());
//                if (n > 0)
//                    poscount++;
//                else if (n < 0)
//                    negcount++;
//                else if (n == 0)
//                    zerocount++;
//                Console.WriteLine("WANT TO ADD ANOTHER NUMBER PRESS 1 ELSE PRESS 0");
//                flag = Convert.ToInt32(Console.ReadLine());
//            } while (flag==1);
//            Console.WriteLine($"count of positive number is {poscount}, Count of negative numbers is {negcount}, Count of Zeros is {zerocount}.");
//        }
//    }
//}
