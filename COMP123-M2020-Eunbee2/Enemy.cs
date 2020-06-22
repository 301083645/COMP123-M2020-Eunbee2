using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_Eunbee2
{
    class Enemy : GameObject
    {
        // Private Instance Variables

        // Public properties

        // Constructor

        public Enemy(string name)
            : base(name)
        {

        }

        // Private methods

        // public methods

        public virtual void FireBullet()
        {
            Console.WriteLine("Firing Bullet!\n");
        }

    }
}
