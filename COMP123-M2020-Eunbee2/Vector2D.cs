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

        // Public Operator Overloads

        public static Vector2D operator +(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x + rhs.x;
            float Ys = lhs.y + rhs.y;
            return new Vector2D(Xs, Ys);
        }

        public static Vector2D operator -(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x - rhs.x;
            float Ys = lhs.y - rhs.y;
            return new Vector2D(Xs, Ys);
        }

        public static Vector2D operator *(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x * rhs.x;
            float Ys = lhs.y * rhs.y;
            return new Vector2D(Xs, Ys);
        }

        public static Vector2D operator *(Vector2D lhs, float rhs)
        {
            float Xs = lhs.x * rhs;
            float Ys = lhs.y * rhs;
            return new Vector2D(Xs, Ys);
        }

        public static Vector2D operator /(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x / rhs.x;
            float Ys = lhs.y / rhs.y;
            return new Vector2D(Xs, Ys);
        }


        // Constructor

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

        // Public static methods

        public static Vector2D Zero()
        {
            return new Vector2D(0.0f, 0.0f);
        }

        public static Vector2D Up()
        {
            return new Vector2D(0.0f, 1.0f);
        }

        public static Vector2D Down()
        {
            return new Vector2D(0.0f, -1.0f);
        }

        public static Vector2D Right()
        {
            return new Vector2D(1.0f, 0.0f);
        }

        public static Vector2D Left()
        {
            return new Vector2D(-1.0f, 0.0f);
        }
    }
}
