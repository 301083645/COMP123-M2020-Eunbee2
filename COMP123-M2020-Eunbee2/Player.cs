using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_Eunbee2
{
    class Player : GameObject
    {
        // Private Instance Variables
        private bool m_shieldsRaised;
        private float m_shieldLevel;


        // Public properties
        public bool ShieldsRaised
        {

            get
            {
                return m_shieldsRaised;
            }
            set
            {
                m_shieldsRaised = value;
            }
        }

        public override float Health 
        { get 
            {
                return m_health;
            }
            set
            {
                /*
                if (ShieldsRaised)
                {
                    m_health = value + 10.0f;
                }
                else
                {
                    m_health = value;
                }
                */

                // use a ternary operator instead
                // m_health = (ShieldsRaised) ? value + ShieldLevel : value;

                if (ShieldsRaised)
                {
                    m_health = value + ShieldLevel;
                    Console.WriteLine($"Player's shields absorbed {ShieldLevel} damage");
                }
                else
                {
                    m_health = value;
                }
            } 
        }

        public float ShieldLevel
        {
            get
            {
                return m_shieldLevel;
            }
            set
            {
                m_shieldLevel = value;
            }
        }


        // Constructor
        public Player()
            : base("Player")
        {
            m_initialize();
        }

        // Private methods
        private void m_initialize()
        {
            m_shieldLevel = 10.0f;
        }

        // public methods
        public void RaiseShields()
        {
            Console.WriteLine("Raising Shields\n");
            ShieldsRaised = true;
        }

        public void LowerShields()
        {
            Console.WriteLine("Lowering Shields\n");
            ShieldsRaised = false;
        }
    }
}
