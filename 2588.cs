// Problem No.2588

using System;

namespace BAEKJOON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            Console.WriteLine(int.Parse(s1) * int.Parse(s2[2].ToString()));
            Console.WriteLine(int.Parse(s1) * int.Parse(s2[1].ToString()));
            Console.WriteLine(int.Parse(s1) * int.Parse(s2[0].ToString()));
            Console.WriteLine(int.Parse(s1) * int.Parse(s2));
        }
    }
}