using Ninject;
using System;

namespace Cl.Imagicair.Injection
{
    public class Guerrero
    {
        private IArma arma;

        public int puntosVida { get; private set; }

        public String nombre;

        public Boolean estaVivo = true;

        public Guerrero(IArma arma, string nombre)
        {
            this.arma = arma;
            this.nombre = nombre;
            puntosVida = 100;
        }

        public void Atacar(Guerrero guerrero)
        {
            if (puntosVida > 0)
            {
                Console.Write($"{nombre} ataca...");
                guerrero.RecibirAtaque(arma.Usar());
            }
            else
                Console.WriteLine($"{nombre} ya es cadáver");
        }

        public int RecibirAtaque(int damage)
        {
            if (!estaVivo)
                Console.WriteLine("Déjenlo, ya está muerto");

            puntosVida -= damage;
            if (estaVivo == true)
            {
                if (puntosVida <= 0)
                {
                    Console.WriteLine($"{nombre} ha muerto");
                    estaVivo = false;
                }
                else
                {
                    Console.WriteLine($"{nombre} tiene {puntosVida} puntos de vida");
                }
            }

            return puntosVida;
        }
    }

}