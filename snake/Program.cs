using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char symb = '*';

            Draw(x1, y1, symb);

            x1 = 4;
            y1 = 5;
            symb = '#';
            Draw(x1, y1, symb);

            Console.ReadLine();
        }
        static void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
