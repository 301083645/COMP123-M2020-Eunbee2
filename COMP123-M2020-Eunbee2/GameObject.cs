using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_Eunbee2
{
    abstract class GameObject
    {
        // Private Instance Members(fields)
        private string m_name;
        protected float m_health;

        //Public properties
        public Transform Transform{ get; set; }

        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

        public virtual float Health
        {
            get
            {
                return m_health;
            }
            set
            {
                m_health = value;
            }
        }

        // Constructor(s)



        /// <summary>
        /// This Constructor requires a name for the game with an optional health value.
        /// By default all GameObjects will have a health value of 100.0f
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        public GameObject(string name, float health = 100.0f)
        {
            Name = name;
            Health = health;

            m_initialize();

            Start();
        }

        //Private Methods
        private void m_initialize()
        {
            Transform = new Transform();
        }

        //public Method

        public override string ToString()
        {
            string outputString = "";
            outputString += $"Name    : {Name}\n";
            outputString += $"Health  : {Health}\n";
            outputString += Transform.ToString();
            return outputString;
        }

        // public abstract methods (Must be OVERRIDDEN in the derived class)
        public abstract void Start();
        public abstract void Update();
        public abstract void Reset();


    }
}
