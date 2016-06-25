using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefense
{
    public class Map
    {

        // readonly's cannot be changed after its created
        public readonly int Width;
        public readonly int Height;


        //constructor method
        // lowercase height and width are method level variables. they only exist inside the method below (thats the variables scope).
        public Map(int width, int height)
        {
            // instant variables exist as long as the object exists
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return              point.X >= 0 && point.X < Width && 
                                point.X >= 0 && point.Y < Height;

            

        }
        



    }
}
