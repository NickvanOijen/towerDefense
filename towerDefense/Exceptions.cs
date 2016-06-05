using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefense
{
    class DefenseExceptions : System.Exception
    {
        public DefenseExceptions()
        {
        }
        public DefenseExceptions(string message) : base(message)
        {
        }
    }


    class OutOfBoundsExceptions : DefenseExceptions
    {
        public OutOfBoundsExceptions()
        {
        }
        public OutOfBoundsExceptions(string message) : base(message)
        {
        }
    }
}
