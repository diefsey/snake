using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 5, '+');
            /*p1.x = 1;
            p1.y = 3;
            p1.sum = '*';*/
            p1.Draw();

            Point p2 = new Point(4, 4, '-');
           /* p2.x = 4;
            p2.y = 4;
            p2.sum = '&';*/
            p2.Draw();

            Console.ReadLine();
        }

        
    }
}
