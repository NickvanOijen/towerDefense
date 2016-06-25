using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 25;
        private const double _accuracy = .8;


        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower (MapLocation location)
        {
            _location = location; 
        }


        public bool IsSuccesfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }


        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccesfulShot())
                    { 
                    invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit an invader");

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("The invader died screaming in agony");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bummer the tower missed");
                    }
                    break;
                }

            }
        }
    }
}

/* DOES exactly the same thing as the FOREACH loop above!!
   
                    for (int index = 0; index < invaders.Length; index++)
                    {
                        Invader invader = invaders[index];
                        //Do stuff with the invader
                    }


    AND

                     while (index < invaders.Length)
                            {
                               Invader invader = invaders[index];
                                //Do stuff with the invader

                                index++;
                            }

    */
