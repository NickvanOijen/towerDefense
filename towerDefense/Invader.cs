using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        //accessor public methods to call on private methods

        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move()
        {
            _pathStep += 1;
        }
    }
}

    

