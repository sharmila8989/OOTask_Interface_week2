using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTask_Interface_week2
{
    class Quadrilateral:Shape
    {
        private const int _numSides = 4;
        public int NumSides
        {
            get { return _numSides; }
        }
        public Quadrilateral(string pColour, string pName) : base(pColour, pName) { }


    }
}
