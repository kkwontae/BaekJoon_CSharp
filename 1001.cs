// Problem No.1001

using System;

namespace BAEKJOON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
        }
    }
}