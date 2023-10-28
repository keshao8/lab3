using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    class Point
    {
        private int x;
        private int y;
        private char symb;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
        }
        public void SetSymb(char symb)
        {
            this.symb = symb;
        }
        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point one = new Point();
            one.SetSymb('(');
            one.Draw(-10, 8);
            Point two = new Point();
            two.SetSymb(')');
            two.Draw(11, 8);
            Point three = new Point();
            three.SetSymb('|');
            three.Draw(10, 9);
            Point four = new Point();
            four.SetSymb('|');
            four.Draw(11, 9);
            Point five = new Point();
            five.SetSymb('/');
            five.Draw(10, 10);
            Point six = new Point();
            six.SetSymb('\\');
            six.Draw(11, 10);
            Console.ReadKey();
        }
    }
}
