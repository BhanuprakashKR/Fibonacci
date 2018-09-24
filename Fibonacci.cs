using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Num");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci series of given num is");
            for (int i = 0; i < num; i++) {
                Console.WriteLine("{0}", fibonacciCal(i));
            }
            Console.ReadLine();
        }

        private static int fibonacciCal(int num)
        {
            int n1=0, n2=1;
            for(int i=0;i<num;i++)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp + n1;
            }
            return n1;
        }
    }
}
