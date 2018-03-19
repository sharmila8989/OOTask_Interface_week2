using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTask_Interface_week2
{
    class Square:Quadrilateral,IShapeProps
    {
        private double _sideLength;
        public double SideLength
        {
            get { return _sideLength; }
            set { _sideLength = value; }
        }
        public Square(string pColour, string pName, double pSideLength) : base(pColour, pName)
        {
            _sideLength = pSideLength;
        }
        public double GetArea()
        {
            return Math.Round((_sideLength * _sideLength),2);
        }
        public double GetPerimeter()
        {
            return Math.Round((4 * _sideLength),2);
        }

    }
}
