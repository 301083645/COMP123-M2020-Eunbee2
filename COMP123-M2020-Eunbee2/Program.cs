using System;
using System.Security.Cryptography.X509Certificates;

namespace COMP123_M2020_Eunbee2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject player = new GameObject("Player");


            //player.Transform.position = new Vector2D();

            //Console.WriteLine(player.Name);
            //Console.WriteLine(player.Transform.ToString());

            Console.WriteLine(player.ToString());

            //listen for any key
            Console.ReadLine();

           

        }
    }
}
