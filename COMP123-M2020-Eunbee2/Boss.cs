﻿using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_Eunbee2
{
    class Boss : Enemy
    {
        // Private instance variables

        // public properties

        // constructor
        public Boss() :
            base("Boss")
        {

        }

        // private methods

        // public methods
        // virtura was written in enemy FireBullet
        public override float FireBullet()
        {
            Console.WriteLine($"{Name} Firing FAT bullet!");
            return 40.0f;
        }




    }
}
