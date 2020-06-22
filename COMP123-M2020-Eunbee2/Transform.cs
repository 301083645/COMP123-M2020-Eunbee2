using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_Eunbee2
{
    class Transform
    {
        // public instance variables
        public Vector2D position;
        public Vector2D Rotation;
        public Vector2D Scale;

        // Constructor
        public Transform()
        {
            m_initialize();
        }

        // Private Methods
        private void m_initialize()
        {
            position = new Vector2D();
            Rotation = new Vector2D();
            Scale = new Vector2D();
        }

        /// <summary>
        /// This method formats the transfrom to show each of it's components
        /// (position, rotation, scale)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += $"Position: " + position.ToString() + "\n";
            outputString += $"Rotation: " + Rotation.ToString() + "\n";
            outputString += $"Scale   : " + Scale.ToString() + "\n";
            return outputString;
        }
    }
}
