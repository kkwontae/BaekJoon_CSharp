// Problem No.2742

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

            for(int i=N; i>0; i--) {
                result.Append(i+"\n");
            }
            Console.WriteLine(result);
        }
    }
}