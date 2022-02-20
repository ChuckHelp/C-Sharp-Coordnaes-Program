using System;

namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The values of X coordinate and Y coordiantes are:");
            Coordinates cood = new Coordinates(1, 0);
            cood.Display();
            Console.WriteLine("                                                  ");


            Coordinates.Shapes.Circle c1 = new Coordinates.Shapes.Circle(cood, 15, 200);
            Console.WriteLine("The Area of circle 1:{0}", c1.GetArea());
            Console.WriteLine("The Shape Score of circle 1:{0}", c1.GetShapeScore());

            Coordinates.Shapes.Circle c2 = new Coordinates.Shapes.Circle(cood, 13, 100);
            Console.WriteLine("The Area of circle 2:{0}", c2.GetArea());
            Console.WriteLine("The Shape Score of circle 2:{0}", c2.GetShapeScore());

            Coordinates.Shapes.Square s1 = new Coordinates.Shapes.Square(cood, 20, 300);
            Console.WriteLine("The Area of square 1 is:{0}", s1.GetArea());
            Console.WriteLine("The Shape Score of square 1 is:{0}", s1.GetShapeScore());

            Coordinates.Shapes.Square s2 = new Coordinates.Shapes.Square(cood, 8, 400);
            Console.WriteLine("The Area of square 2 is:{0}", s2.GetArea());
            Console.WriteLine("The Shape Score of square 2 is:{0}", s2.GetShapeScore());

            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("The PointScore of coordinates (1,0) is:{0}",
             (c1.GetShapeScore() + s1.GetShapeScore()) - 0.25 * (c2.GetShapeScore() + s2.GetShapeScore()));

            Console.WriteLine("-------------------------------------------------------");


            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        //Coordinate class starts here
        public class Coordinates
        {

            //member variables
            public int xcoord;
            public int ycoord;

            public Coordinates(int xcoord, int ycoord)
            {
                this.xcoord = xcoord;
                this.ycoord = ycoord;
            }
            public void Display()
            {
                Console.WriteLine("X_Coordinate is:{0}", xcoord);
                Console.WriteLine("Y_Coordinate is:{0}", ycoord);
            }


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
            } //Shapes class ends by here
        } //end class Coordinates
    }
}