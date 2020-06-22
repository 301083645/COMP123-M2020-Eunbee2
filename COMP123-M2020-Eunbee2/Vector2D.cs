using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace COMP123_M2020_Eunbee2
{
    class Vector2D
    {
        // Public instance variables
        public float x;
        public float y;

        /// <summary>
        /// This Constructor takes x and y as optional parameters
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector2D(float x = 0.0f, float y = 0.0f)
        {
            this.x = x;
            this.y = y;
        }

        // public methods

        /// <summary>
        /// This method returns the value of the x and y components with the format (x, y) as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = $"({x}, {y})";

            return outputString;
        }
    }
}
