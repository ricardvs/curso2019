using System;

namespace Cl.Imagicair.Injection
{
    public class Rifle : IArma
    {
        private const int maxDamage = 100;
        private const int dificultad = 50;

        private Random random = new Random();

        public int Usar()
        {
            if (random.Next(100) > 50)
            {
                int damage = random.Next(maxDamage);
                Console.WriteLine($"Se escucha un gran estruendo y se producen {damage} punto(s) de daño");
                return damage;
            }
            else
            {
                Console.WriteLine($"Se escucha un gran estruendo pero no acierta");
                return 0;
            }
        }
    }

}