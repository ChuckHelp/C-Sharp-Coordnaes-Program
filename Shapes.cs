using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabII_OOP
{
    //Shapes class starts here
    public abstract class Shapes
    {
        public int Lenght;
        public int instancePoints;
        double Area;
        double typePoints;
        Coordinates coord;
        public abstract double GetArea();
        public abstract double GetShapeScore();

        
       
    } //Shapes class ends by here
}
