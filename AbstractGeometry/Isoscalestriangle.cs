using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace AbstractGeometry
{
    internal class IsoscelesTriangle:Triangle
    {
        double @base;// ключевое слово означающее базовый класс. Ключевые слова нельзя использовать для именования своих сущностей.
        //НО, если перед ключевым словом поставить @, то его можно использовать для именования своих сущностей
        double side;

        public double Base
        {
            get => @base;
            set => @base = FilterSize(value);
        }

        public double Side// свойства
        {
            get => side;
            set => side = FilterSize(value);
        }

        public IsoscelesTriangle(double @base, double side, int startX, int startY, int linewidth, Color color)
            :base(startX, startY, linewidth, color)
        {
            Base = @base;
            Side = side;
        }

        public override double GetHeight()
        {
            return Math.Sqrt(Math.Pow(Side, 2)- Math.Pow(Base/2,2));
        }
        public override double GetArea()
        {
            return Base * GetHeight() / 2;

        }
        public override double GetPerimeter()
        {
            return 2 * Side + Base;
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, Linewidth);
            Point[] vertices = new Point[]
                {
                    new Point(StartX,StartY + (int)GetHeight()),
                    new Point (StartX+(int)Base, StartY+(int)GetHeight()),
                    new Point (StartX + (int)Base/2, StartY)
                };                
            
            e.Graphics.DrawPolygon(pen, vertices);
           
            SolidBrush brush = new SolidBrush(Color);

            e.Graphics.FillPolygon(brush, vertices);

        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Основание: {Base}");
            Console.WriteLine($"Сторона: {Side} ");
            base.Info(e);
        }
    }
}
