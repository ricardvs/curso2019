using System;
using System.Collections.Generic;

namespace Cl.Imagicair.Simple
{
    public class Cajero
    {
        private readonly int[] denominaciones = {20000, 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1};
        private readonly IDictionary<int, int> desgloseVuelto = new Dictionary<int, int>();

        public DesgloseVuelto CalcularVuelto(int valor, int dineroPago)
        {
            int remanente = dineroPago - valor;

            foreach (int denominacion in denominaciones)
            {
                desgloseVuelto[denominacion] = remanente / denominacion;
                remanente %= denominacion;
            }

            return new DesgloseVuelto(desgloseVuelto);
        }
    }

    public class DesgloseVuelto
    {
        public DesgloseVuelto(IDictionary<int, int> cantidadesPorDenominacion)
        {
            De20000 = cantidadesPorDenominacion[20000];
            De10000 = cantidadesPorDenominacion[10000];
            De5000 = cantidadesPorDenominacion[5000];
            De1000 = cantidadesPorDenominacion[1000];
            De2000 = cantidadesPorDenominacion[2000];
            De1000 = cantidadesPorDenominacion[1000];
            De500 = cantidadesPorDenominacion[500];
            De100 = cantidadesPorDenominacion[100];
            De50 = cantidadesPorDenominacion[50];
            De10 = cantidadesPorDenominacion[10];
            De5 = cantidadesPorDenominacion[5];
            De1 = cantidadesPorDenominacion[1];
        }

        public int De1 { get; private set; }
        public int De5 { get; private set; }
        public int De10 { get; private set; }
        public int De50 { get; private set; }
        public int De100 { get; private set; }
        public int De500 { get; private set; }
        public int De1000 { get; private set; }
        public int De2000 { get; private set; }
        public int De5000 { get; private set; }
        public int De10000 { get; private set; }
        public int De20000 { get; private set; }
    }
}