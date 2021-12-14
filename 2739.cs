// Problem No.2739

using System;

namespace BAEKJOON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i < 10; i++) {
                Console.WriteLine(N + " * " + i + " = " + N*i);
            }
        }
    }
}