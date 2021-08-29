//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    class sum_of_multi_array
//    {
//        static void Main(string[] args)
//        {
//            int i, j, n, M, N;
//            Console.WriteLine("Enter the size of array");
//            M = Convert.ToInt32(Console.ReadLine());
//            N = Convert.ToInt32(Console.ReadLine());

//            int[,] arr1 = new int[M, N];
//            int[,] arr2 = new int[M, N];
//            int[,] arr3 = new int[M, N];
//            // setting matrix row and columns size
//            n = 3;
//            Console.Write("Enter elements in the first matrix:\n");
//            for (i = 0; i < M; i++)
//            {
//                for (j = 0; j < N; j++)
//                {
//                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            Console.Write("Enter elements in the second matrix:\n");
//            for (i = 0; i < M; i++)
//            {
//                for (j = 0; j < N; j++)
//                {
//                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            Console.Write("First matrix is:\n");
//            for (i = 0; i < M; i++)
//            {
//                Console.Write("\n");
//                for (j = 0; j < N; j++)
//                    Console.Write("{0}\t", arr1[i, j]);
//            }
//            Console.Write("Second matrix is:\n");
//            for (i = 0; i < M; i++)
//            {
//                Console.Write("\n");
//                for (j = 0; j < N; j++)
//                    Console.Write("{0}\t", arr2[i, j]);
//            }
//            for (i = 0; i < M; i++)
//                for (j = 0; j < N; j++)
//                    arr3[i, j] = arr1[i, j] + arr2[i, j];
//            Console.Write("Adding two matrices: \n");
//            for (i = 0; i < M; i++)
//            {
//                Console.Write("\n");
//                for (j = 0; j < N; j++)
//                    Console.Write("{0}\t", arr3[i, j]);
//            }
//        }
//    }
//}
