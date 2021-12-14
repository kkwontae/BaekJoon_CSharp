// Problem No.1330

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

            if (A > B) {
                Console.WriteLine(">");
            }
            else if (A < B) { 
                Console.WriteLine("<");
            }
            else {
                Console.WriteLine("==");
            }
        }
    }
}