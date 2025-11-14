using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Square:Rectangle
    {
        public Square (double side, int starX, int starY, int lineWidth, Color color):
            base(side, side, starX, starY, lineWidth, color){}
        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => Math.Pow(Width,2);

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, Linewidth);
            SolidBrush brush = new SolidBrush(Color);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
            e.Graphics.FillRectangle(brush, StartX, StartY, (float)Width, (float)Height);
        }

         public override void Info(PaintEventArgs e)
        {           
            base.Info(e);
            Console.WriteLine();
        }        

    }
}
