// Problem No.2741

using System;
using System.Text;

namespace BAEKJOON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            for(int i=1; i<=N; i++) {
                result.Append(i+"\n");
            }
            
            Console.WriteLine(result);
        }
    }
}