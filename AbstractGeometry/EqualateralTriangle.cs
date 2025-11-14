using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractGeometry
{
    internal class EqualateralTriangle:IsoscelesTriangle
    {
        public EqualateralTriangle(double side, int startX, int  startY, int linewidth, Color color):
            base(side,side,startX,startY, linewidth, color) { }

       
            
    }
}
