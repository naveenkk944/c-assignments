//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    class Copy_array
//    {
//        static void Main(string[] args)
//        {
//            int[] array = new int[10];
//            int[] array1 = new int[10];
//            int min = int.MaxValue;
//            Console.WriteLine("Please enter the values of array");
//            for (int i = 0; i < 10; i++)
//            {
//                array[i] = Convert.ToInt32(Console.ReadLine());

//            }
//            array1 = Enumerable.Reverse(array).ToArray();
            
//            Console.WriteLine("Original array"+String.Join(',', array));
//            Console.WriteLine("reversed array"+String.Join(',', array1));
//        }
//    }
//}