using System;

namespace Transporte
{
    class Program
    {
        static void Main(string[] args)
        {
            MeiosDeTransporte Carro = new Terrestre("Jeep", "Jeep", "Renegate", 20, 4);

            Carro.Abastecer(5);

            Console.ReadKey();
        }
    }
}
