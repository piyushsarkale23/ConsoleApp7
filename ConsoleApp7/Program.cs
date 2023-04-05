using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Program
    {
      static void Swap(int a,int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }
        static void main(String[] args)
        {
            int a = 12, b = 13;
            Swap(a,b);
            Console.WriteLine($"The value of a is {a} and value of b is {b}");
        }


    }
}
