using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabII_OOP
{

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


        
    } //end class Coordinates
}
