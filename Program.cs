using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            var sum = 0.0;
            if (n < 20)
            {
                if (a == "day")
                    sum = (n * 0.79) + 0.70;
                else if (a == "night")
                    sum = (n * 0.90) + 0.70;
            }
            else if (n < 100)
                sum = n*0.09;
            else
                sum = n * 0.06;
            Console.WriteLine(sum);

        }
    }
    }

