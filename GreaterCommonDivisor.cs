using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            while (A % B != 0)
            {
                int x = A % B;
                A = B;
                B = x;
            }
            Console.WriteLine(B);
        }
    }
}
