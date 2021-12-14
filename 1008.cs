// Problem No.1008

using System;

namespace BAEKJOON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            
            Console.WriteLine(double.Parse(s[0]) / double.Parse(s[1]));
        }
    }
}