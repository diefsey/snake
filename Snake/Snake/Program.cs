﻿using System;
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
            int x1 = 1;
            int y1 = 3;
            char sum1 = '*';

            Draw(x1, x1, sum1);

            int x2 = 3;
            int y2 = 5;
            char sum2 = '#';

            Draw(x2, x2, sum2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sum) {

            Console.SetCursorPosition(x, y);
            Console.Write(sum);
        }
    }
}
