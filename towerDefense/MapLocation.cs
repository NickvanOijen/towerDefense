using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base (x , y)
        {
            if (map.OnMap(this))
            {
                throw new OutOfBoundsExceptions(x + "," + y + "is outside the boundaties of the map");
            }
        }
    }
}
