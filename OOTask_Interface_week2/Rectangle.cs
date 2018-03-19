﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTask_Interface_week2
{
    class Rectangle:Quadrilateral,IShapeProps
    {
        private double _length;
        private double _width;

        public double Lenght { get; set; }
        public double Widht { get; set; }
        public Rectangle(string pColour, string pName, double pLenght, double pWidth) : base(pColour, pName)
        {
            _length = pLenght;
            _width = pWidth;
        }
        public double GetArea()
        {
            return Math.Round((_length * _width),2);
        }
        public double GetPerimeter()
        {
            return Math.Round((2 * (_length + _width)),2);
        }


    }
}
