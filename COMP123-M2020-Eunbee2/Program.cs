using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace COMP123_M2020_Eunbee2
{
    class Program
    {
        static void Main(string[] args)
        {


            
            Player player = new Player();

            
            
            player.Transform.position = new Vector2D(100.0f, 100.0f);
            Console.WriteLine(player.ToString());
            player.RaiseShields();

            Enemy redEnemy = new Enemy("Red Enemy");
            redEnemy.Transform.position = new Vector2D(200.0f, 200.0f);
            Console.WriteLine(redEnemy.ToString());

            float distance = Vector2D.Distance(player.Transform.position, redEnemy.Transform.position);
            Console.WriteLine($"The distance between the player and the red enemy is {distance}");

            player.Health -= redEnemy.FireBullet();
            Console.WriteLine(player.ToString());

            Boss boss = new Boss();
            boss.Transform.position = Vector2D.Zero();
            Console.WriteLine(boss.ToString());

            float bossdistance = Vector2D.Distance(player.Transform.position, boss.Transform.position);
            Console.WriteLine($"The distance between the player and the Boss enemy is {bossdistance}");

            player.Health -= boss.FireBullet();
            Console.WriteLine(player.ToString());




            //listen for any key
            Console.ReadLine();

           

        }
    }
}
