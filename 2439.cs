// Problem No.2439

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
                for(int j=N; j>i; j--) {
                    result.Append(" ");
                }
                for(int j=0; j<i; j++) {
                    result.Append("*");
                }
                result.Append("\n");
            }
            Console.WriteLine(result);
        }
    }
}