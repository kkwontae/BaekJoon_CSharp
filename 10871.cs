// Problem No.10871

using System;
using System.Text;

namespace BAEKJOON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();

            int N = int.Parse(s[0]);
            int X = int.Parse(s[1]);

            string[] a = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();

            for(int i=0; i<N; i++) {
                if(int.Parse(a[i]) < X) {
                    result.Append(int.Parse(a[i])+" ");
                }
            }
            Console.WriteLine(result);
        }
    }
}