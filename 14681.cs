// Problem No.14681

using System;

namespace BAEKJOON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if(x > 0) {
                if(y > 0) {
                    Console.WriteLine(1);
                }
                else if(y < 0) {
                    Console.WriteLine(4);
                }
            }
            else if(x < 0) {
                if(y > 0) {
                    Console.WriteLine(2);
                }
                else if(y < 0) {
                    Console.WriteLine(3);
                }
            }
        }
    }
}