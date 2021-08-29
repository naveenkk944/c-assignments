using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class menu_matrix
    {
        static void Main(string[] args)
        {
            int M, N,i,j;

            Console.WriteLine("Enter the size of array ");
            M = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[M, N];

            int[] sum = new int[M];
            int[] sum2 = new int[N];
            next:
            Console.WriteLine("Please enter your choice:");
            Console.WriteLine("1.To input elements into matrix of size m x n");
            Console.WriteLine("2.To display elements of matrix of size m x n");
            Console.WriteLine("3.Sum of all elements of matrix of size m x n");
            Console.WriteLine("4.To display row-wise sum of matrix of size m x n");
            Console.WriteLine("5.To display column-wise sum of matrix of size m x n");
            Console.WriteLine("6.To create transpose of matrix B of size n x m");
            Console.WriteLine("7.Exit");
            var choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter elements in the first matrix:\n");
                    for (i = 0; i < M; i++)
                    {
                        for (j = 0; j < N; j++)
                        {
                            arr[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    break;
                case 2:
                    Console.Write("\nmatrix Elements are:\n");
                    for (i = 0; i < M; i++)
                    {
                        Console.Write("\n");
                        for (j = 0; j < N; j++)
                            Console.Write("{0}\t", arr[i, j]);
                    }
                    break;
                case 3:
                    int sum1=0;
                    Console.Write("\nEnter elements in the first matrix:\n");
                    for (i = 0; i < M; i++)
                    {
                        for (j = 0; j < N; j++)
                        {
                            sum1 = sum1 + arr[i, j];
                        }
                    }
                    Console.Write($"\nSum of all elemets of matrix is {sum1}");
                    break;
                case 4:
                    for (i = 0; i < M; i++)
                    {
                        sum[i] = 0;
                        for (j = 0; j < N; j++)
                        {
                            sum[i] = sum[i] + arr[i, j];
                        }
                    }
                    Console.Write($"\nSum of elemnts of each row is:\n");
                    Console.WriteLine(String.Join('\n', sum));
                    break;
                case 5:
                    for (i = 0; i < N; i++)
                    {
                        sum2[i] = 0;
                        for (j = 0; j < M; j++)
                        {
                            sum2[i] = sum2[i] + arr[j, i];
                        }
                    }
                    Console.Write($"\nSum of elements oif each column is:\n");
                    Console.WriteLine(String.Join('\n', sum2));
                    break;
                case 6:
                    Console.Write("\nTranspose matrix:\n");
                    int[,] arr2 = new int[N, M];
                    for (i = 0; i < M; i++)
                    {
                        for (j = 0; j < N; j++)
                        {
                            arr2[i, j] = arr[j, i];
                        }
                    }
                    break;
                case 7:
                    goto end;
                    break;
                default:
                    goto end;
            }
            goto next;
        end:
            Console.WriteLine("thank You");

        }
    }
}
