using LabII_OOP;

namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine($"The count of input arguments is {args.Length}");
            foreach (var arg in args)
            {
                Console.WriteLine($"arg{i} = {args[i]}");
            }


            Console.WriteLine("The values of X coordinate and Y coordiantes are:");
            LabII_OOP.Coordinates cood = new LabII_OOP.Coordinates(1, 0);
            cood.Display();
            Console.WriteLine("                                                  ");


            Circle c1 = new Circle(cood, 15, 200);
            Console.WriteLine("The Area of circle 1:{0}", c1.GetArea());
            Console.WriteLine("The Shape Score of circle 1:{0}", c1.GetShapeScore());

            Circle c2 = new Circle(cood, 13, 100);
            Console.WriteLine("The Area of circle 2:{0}", c2.GetArea());
            Console.WriteLine("The Shape Score of circle 2:{0}", c2.GetShapeScore());

            Square s1 = new Square(cood, 20, 300);
            Console.WriteLine("The Area of square 1 is:{0}", s1.GetArea());
            Console.WriteLine("The Shape Score of square 1 is:{0}", s1.GetShapeScore());

            Square s2 = new Square(cood, 8, 400);
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
    }
}