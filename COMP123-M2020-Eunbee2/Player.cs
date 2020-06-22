using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_Eunbee2
{
    class Player : GameObject
    {
        // Private Instance Variables

        // Public properties

        // Constructor
        public Player()
            : base("Player")
        {

        }

        // Private methods

        // public methods
        public void RaiseShields()
        {
            Console.WriteLine("Raising Shields\n");
        }
    }
}
