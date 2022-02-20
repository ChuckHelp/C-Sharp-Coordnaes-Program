namespace LabII_OOP
{
    //Shapes class starts here
    public abstract class Shapes
    {
        public int Lenght;
        public int instancePoints;
        protected double Area;
        protected double typePoints;
        protected Coordinates coord;
        public abstract double GetArea();
        public abstract double GetShapeScore();

        
       
    } //Shapes class ends by here
}
