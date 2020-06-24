using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace COMP123_M2020_Eunbee2
{
    class Program
    {
        static void Main(string[] args)
        {


            float playerSpeed = 20.0f; // 20 units
            Player player = new Player();

            
            
            player.Transform.position = new Vector2D(100.0f, 100.0f);
            Console.WriteLine(player.ToString());
            player.RaiseShields();

            
            player.Transform.position += Vector2D.Right() * playerSpeed;
            Console.WriteLine(player.ToString());

            //player.Transform.position *= playerSpeed;
            //Console.WriteLine(player.ToString());

            Vector2D vector1 = new Vector2D(0.0f, 3.0f);
            Vector2D vector2 = new Vector2D(4.0f, 0.0f);
            Console.WriteLine("Value of vector1 is: " + vector1.ToString());
            Console.WriteLine("Value of vector2 is: " + vector2.ToString());


            float dot = Vector2D.Dot(vector1, vector2);
            Console.WriteLine($"The Dot product is: {dot}");

            float distance = Vector2D.Distance(vector1, vector2);
            Console.WriteLine($"The Distance between vector1 and vector2 is: {distance}");




            //listen for any key
            Console.ReadLine();

           

        }
    }
}
