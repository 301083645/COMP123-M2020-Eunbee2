using System;
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

            
            player.Transform.position += Vector2D.Left() * playerSpeed;
            Console.WriteLine(player.ToString());

            //player.Transform.position *= playerSpeed;
            //Console.WriteLine(player.ToString());

            //listen for any key
            Console.ReadLine();

           

        }
    }
}
