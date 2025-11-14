//#define ABSTRACT_1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices; //DLL Import
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (
                    Console.WindowLeft, Console.WindowTop,
                    Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs( graphics, window_rect );
            //e.Graphics.DrawRectangle(new Pen(Color.Red), 100, 100, 500, 300);
#if ABSTRACT_1
            Rectangle rectangle = new Rectangle(200, 120, 100, 50, 3, Color.SkyBlue);
            rectangle.Info(e);

            Square square = new Square(20, 250, 200, 5, Color.Red);
            square.Info(e);

            Circle circle = new Circle(20, 500, 200, 5, Color.YellowGreen);
            circle.Info(e);

            IsoscelesTriangle iso = new IsoscelesTriangle(50, 350, 150, 150, 3, Color.Blue);
            iso.Info(e);

            EqualateralTriangle equ = new EqualateralTriangle(50, 650, 200, 4, Color.DeepPink);
            equ.Info(e);

#endif
            Shape[] shapes =
         {
            new Rectangle(200, 120, 100, 50, 3, Color.SkyBlue),
            new Circle(20, 500, 200, 5, Color.YellowGreen),
            new Square(20, 250, 200, 5, Color.Red),
            new IsoscelesTriangle(50, 350, 150, 150, 3, Color.Blue),
            new EqualateralTriangle(50, 650, 200, 4, Color.DeepPink)

        };

            for (int i = 0; i < shapes.Length; i++)
            {
                if (!(shapes[i] is IHaveDiagonal))
                {
                    shapes[i].Draw(e);
                }
            }

        }      

        

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        
    }
}
