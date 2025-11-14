using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal abstract class Triangle:Shape
    {
        public abstract double GetHeight();
        public Triangle(int startX, int startY, int liewith, System.Drawing.Color color):
            base(startX, startY, liewith, color)
        { }  

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Высота треугольника: {GetHeight()}" );
            base.Info(e);
        }
        
    }

}
