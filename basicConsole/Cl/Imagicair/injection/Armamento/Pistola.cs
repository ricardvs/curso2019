using System;

namespace Cl.Imagicair.Injection
{
    public class Pistola : IArma
    {
        private const int maxDamage = 50;

        private const int dificultad = 20;

        private Random random = new Random();

        public int Usar()
        {
            if (random.Next(100) > 50)
            {
                int damage = random.Next(maxDamage);
                Console.WriteLine($"Se escucha un estruendo y se producen {damage} punto(s) de daño.");
                return damage;
            }
            else
            {
                Console.WriteLine($"Se escucha un estruendo pero no acierta");
                return 0;
            }
        }
    }

}