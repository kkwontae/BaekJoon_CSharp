// Problem No.15552

using System;
using System.Text;

namespace BAEKJOON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for(int i=0; i<T; i++) {
                string[] s = Console.ReadLine().Split();
                
                int A = int.Parse(s[0]);
                int B = int.Parse(s[1]);

                result.Append(A+B+"\n");
            }
            Console.WriteLine(result);
        }
    }
}