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

        public virtual float FireBullet()
        {
            Console.WriteLine($"{Name} Firing Bullet!\n");
            return 20.0f;
        }

        
        // public overridden methods (must ovveride)
        public override void Start()
        {
            Console.WriteLine($"{this.GetType()}Start method");
            Health = 50.0f;
        }

        public override void Update()
        {

        }

        public override void Reset()
        {

        }


    }
}
