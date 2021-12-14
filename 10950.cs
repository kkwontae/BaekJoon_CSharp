// Problem No.10950

using System;

namespace BAEKJOON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for(int i=0; i<T; i++)
            {
                string[] s = Console.ReadLine().Split();

                Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
            }
        }
    }
}