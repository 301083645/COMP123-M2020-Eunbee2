using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_Eunbee2
{
    class GameObject
    {
        // Private Instance Members(fields)
        private string m_name;

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

        // Constructor(s)
        public GameObject(string name)
        {
            Name = name;

            m_initialize();
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
            outputString += Transform.ToString();
            return outputString;
        }
    }
}
