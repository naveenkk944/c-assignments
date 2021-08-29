//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    class multi_array_multiplication
//    {
//        static void Main(string[] args)
//        {
//            int i, j, M, N, P, Q;
//            Console.WriteLine("Enter the size of array 1");
//            M = Convert.ToInt32(Console.ReadLine());
//            N = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the size of array 2");
//            P = Convert.ToInt32(Console.ReadLine());
//            Q = Convert.ToInt32(Console.ReadLine());
//            if (N != P)
//            {
//                Console.WriteLine("Matrix multiplication not possible");
//            }
//            else
//            {
//                int[,] arr1 = new int[M, N];
//                int[,] arr2 = new int[P, Q];
//                int[,] arr3 = new int[M, Q];
//                // setting matrix row and columns size
//                ;
//                Console.Write("Enter elements in the first matrix:\n");
//                for (i = 0; i < M; i++)
//                {
//                    for (j = 0; j < N; j++)
//                    {
//                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
//                    }
//                }
//                Console.Write("Enter elements in the second matrix:\n");
//                for (i = 0; i < P; i++)
//                {
//                    for (j = 0; j < Q; j++)
//                    {
//                        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
//                    }
//                }
//                Console.Write("First matrix is:\n");
//                for (i = 0; i < M; i++)
//                {
//                    Console.Write("\n");
//                    for (j = 0; j < N; j++)
//                        Console.Write("{0}\t", arr1[i, j]);
//                }
//                Console.Write("\nSecond matrix is:\n");
//                for (i = 0; i < P; i++)
//                {
//                    Console.Write("\n");
//                    for (j = 0; j < Q; j++)
//                        Console.Write("{0}\t", arr2[i, j]);
//                }
//                for (i = 0; i < M; i++)
//                {
//                    for (j = 0; j < Q; j++)
//                    {
//                        arr3[i, j] = 0;
//                        for (int k = 0; k < N; k++)
//                        {
//                            arr3[i, j] += arr1[i, k] * arr2[k, j];
//                        }
//                    }
//                }
//                Console.Write("Adding two matrices: \n");
//                for (i = 0; i < M; i++)
//                {
//                    Console.Write("\n");
//                    for (j = 0; j < Q; j++)
//                        Console.Write("{0}\t", arr3[i, j]);
//                }
//            }
//        }
//    }
//}
