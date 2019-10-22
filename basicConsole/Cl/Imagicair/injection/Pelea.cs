using Ninject;
using Ninject.Parameters;
using System;

namespace Cl.Imagicair.Injection
{
    public class Pelea
    {
        private Guerrero ninja;
        private Guerrero pistolero;

        private void Init()
        {
            var kernel = new StandardKernel();

            kernel.Bind<Guerrero>()
                .To<Guerrero>()
                .Named("ninja")
                .WithConstructorArgument("arma", request => kernel.Get<Espada>())
                .WithConstructorArgument("nombre", "Garu-San");

                kernel.Bind<Guerrero>()
                .To<Guerrero>()
                .Named("pistolero")
                .WithConstructorArgument("arma", request => kernel.Get<Pistola>())
                .WithConstructorArgument("nombre", "Er Barsimso");;

            ninja = kernel.Get<Guerrero>("ninja");
            pistolero = kernel.Get<Guerrero>("pistolero");
        }

        private void DesarrollarBatalla()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nRound {i+1}");
                ninja.Atacar(pistolero);
                pistolero.Atacar(ninja);
            }
        }


        public static void Main()
        {
            Console.WriteLine("Comenzando pelea...");
            var pelea = new Pelea();
            pelea.Init();
            pelea.DesarrollarBatalla();
        }
    }
}