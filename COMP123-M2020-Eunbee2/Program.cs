using System;
using System.Security.Cryptography.X509Certificates;

namespace COMP123_M2020_Eunbee2
{
    class Program
    {
        static void Main(string[] args)
        {


            //GameObject player = new GameObject("Player");
            Player player = new Player();

            Enemy greenEnemy = new Enemy("GreenEnemy");
            Enemy redEnemy = new Enemy("RedEnemy");
            Boss bossEnemy = new Boss();

            //player.Transform.position = new Vector2D();

            //Console.WriteLine(player.Name);
            //Console.WriteLine(player.Transform.ToString());

            
            player.Transform.position = new Vector2D(100.0f, 100.0f);
            Console.WriteLine(player.ToString());
            player.RaiseShields();

           
            greenEnemy.Transform.position = new Vector2D(60.0f, 80.0f);
            Console.WriteLine(greenEnemy.ToString());
            greenEnemy.FireBullet();

            redEnemy.Transform.position = new Vector2D();
            Console.WriteLine(redEnemy.ToString());
            redEnemy.FireBullet();

            
            bossEnemy.Transform.position = new Vector2D(100.0f, 200.0f);
            Console.WriteLine(bossEnemy.ToString());
            bossEnemy.FireBullet();



            //listen for any key
            Console.ReadLine();

           

        }
    }
}
