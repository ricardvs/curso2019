using System;

namespace Cl.Imagicair.Injection
{
    public class Espada : IArma
    {
        private const int maxDamage = 30;
        private const int dificultad = 70;

        private Random random = new Random();

        public int Usar()
        {
            if (random.Next(100) > 50)
            {
                int damage = random.Next(maxDamage);
                Console.WriteLine($"Se escucha un chis-chas en el aire y se producen {damage} punto(s) de daño");
                return damage;
            }
            else
            {
                Console.WriteLine($"Se escucha un chis-chas en el aire pero no acierta");
                return 0;
            }
        }
    }

}