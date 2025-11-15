using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Circle:Shape
    {
        double radius;
        public double Radius
        {
            get => radius;
            set => radius = FilterSize(value);
        }

        public Circle(double radius, int startX, int startY, int linewidth, Color color)
            :base(startX, startY, linewidth, color) 
        {
            Radius = radius;
            
        }
        public override double GetArea() => Math.PI * Math.Pow(Radius,2);
                
        public override double GetPerimeter() => 2 * Math.PI * Radius;
        
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, Linewidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, (float)(2 * Radius), (float)(2 * Radius));
            SolidBrush brush = new SolidBrush(Color);
          
            e.Graphics.FillEllipse(brush, StartX, StartY, (float)(2 * Radius), (float)(2 * Radius));
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"{this.GetType()}");
            base.Info(e);
            Console.WriteLine();
                
        }
    }
}
