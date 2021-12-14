// Problem No.10430

using System;

namespace BAEKJOON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();

            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int C = int.Parse(s[2]);

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}