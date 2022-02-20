using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabII_OOP
{
    public class Circle : Shapes
    {
        public Circle(Coordinates cood, int lenght, int InstancePoints)
        {
            this.Lenght = lenght;
            this.instancePoints = InstancePoints;
            this.coord = cood;
            Area = GetArea();
            typePoints = GetShapeScore();
        }
        public double GetTypePoints()
        {
            return 2;
        }
        public override double GetArea()
        {

            return (Lenght * Lenght) / (4 * Math.PI);
        }
        public override double GetShapeScore()
        {
            return (GetTypePoints() * (instancePoints) / Area);
        }
    }
}
