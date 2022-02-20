namespace LabII_OOP
{
    public class Square : Shapes
    {
        public Square(Coordinates cood, int lenght, int InstancePoints)
        {
            this.Lenght = lenght;
            this.instancePoints = InstancePoints;
            this.coord = cood;
            Area = GetArea();
            typePoints = GetShapeScore();
        }
        public double GetTypePoints()
        {
            return 1;
        }
        public override double GetArea()
        {
            return Lenght / 4 * Lenght / 4;
        }
        public override double GetShapeScore()
        {
            return (GetTypePoints() * ((instancePoints) / GetArea()));
        }
    }
}
