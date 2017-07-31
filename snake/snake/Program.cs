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
            Console.SetBufferSize(80, 25);

            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Drow();
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Drow();
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            leftline.Drow();
            VerticalLine reightline = new VerticalLine(0, 24, 78, '+');
            reightline.Drow();


            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Console.ReadLine();
        }
    }
}
