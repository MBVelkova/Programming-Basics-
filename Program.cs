using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Abs(x2 - x1) * Math.Abs(y2 - y1));
            Console.WriteLine(2*(Math.Abs(x2 - x1) + Math.Abs(y2 -y1)));



            
                
            }
        }
    }

